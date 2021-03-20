using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForecastLibrary;
using Microsoft.ML;
using Microsoft.ML.Trainers;
using Microsoft.ML.Trainers.FastTree;

namespace Forecast
{
    public class ForecastingManager
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public List<ProcessOutput> FindLatestOrderDays()
        {
            List<ProcessOutput> output = new List<ProcessOutput>();

            foreach (Product product in Products)
            {
                ProcessOutput currentOutput = new ProcessOutput();
                currentOutput.Code = product.Code;
                currentOutput.DaysToOrder = FindLatestOrderDay(product);
                output.Add(currentOutput);
            }

            return output;
        }

        private float FindLatestOrderDay(Product product)
        {
            return PredictDemandForDay(product);
        }

        private float PredictDemandForDay(Product product)
        {
            // check if data is valid
            if (product.Code == null || product.Sales == null)
            {
                return -1999.99f;
            }
            else if (product.Sales.Count < 1)
            {
                return -1999.99f;
            }

            MLContext mlContext = new MLContext();

            // 1. Import or create training data
            Sold[] sold = product.Sales.ToArray();
            IDataView trainingData = mlContext.Data.LoadFromEnumerable(sold);

            // 2. Specify data preparation and model training pipeline
            var pipeline = mlContext.Transforms.Concatenate("Features", "Day", "Month", "Year")
                .Append(mlContext.Regression.Trainers.LbfgsPoissonRegression(labelColumnName: "Quantity"));

            // 3. Train model
            var model = pipeline.Fit(trainingData);

            float inventory = product.Inventory;

            // DEBUG
            List<string> predicts = new List<string>();
            // END DEBUG

            float num = 1;
            while (inventory > 0)
            {
                // 4. Make a prediction
                var salesOnDay = new Sold() { Day = sold[sold.Length - 1].Day + num, Month = 1, Year = 2021 };
                var unitsSold = mlContext.Model.CreatePredictionEngine<Sold, Result>(model).Predict(salesOnDay);
                inventory -= unitsSold.UnitsSold;

                num++;

                // DEBUG
                predicts.Add(unitsSold.UnitsSold.ToString());
                // END DEBUG
            }

            // DEBUG
            //File.WriteAllLines("unitsSoldEachDay.txt", predicts.ToArray());
            // END DEBUG

            num--;
            //num *= 2.25f;
            float result = num - product.LeadTime;

            return result;
        }
    }
}
