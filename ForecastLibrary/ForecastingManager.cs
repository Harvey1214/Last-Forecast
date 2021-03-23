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
        public PredictionAlgorithm PredictionAlgorithm { get; set; } = PredictionAlgorithm.AVERAGE;

        public List<ProcessOutput> Results { get; set; }

        public List<ProcessOutput> FindLatestOrderDays()
        {
            List<ProcessOutput> output = new List<ProcessOutput>();

            foreach (Product product in Products)
            {
                ProcessOutput currentOutput = FindLatestOrderDay(product);
                output.Add(currentOutput);
            }

            output.RemoveAll(o => o == null);
            output.RemoveAll(o => o.Product == null);

            Results = output;
            return output;
        }

        private ProcessOutput FindLatestOrderDay(Product product)
        {
            switch (PredictionAlgorithm)
            {
                case PredictionAlgorithm.AVERAGE:
                    Average average = new Average(product);
                    return average.Predict();
                case PredictionAlgorithm.MEDIAN:
                    break;
                case PredictionAlgorithm.FASTTREETWEEDIE:
                    try
                    {
                        return PredictDemandForDayWithFastTreeTweedie(product);
                    }
                    catch
                    {
                        return new ProcessOutput() { Product = new Product() { Code = "Exception occured" } };
                    }
                case PredictionAlgorithm.FASTFOREST:
                    try
                    {
                        return PredictDemandForDayWithFastForest(product);
                    }
                    catch
                    {
                        return new ProcessOutput() { Product = new Product() { Code = "Exception occured" } };
                    }
                case PredictionAlgorithm.LBFGSPOISSONREGRESSION:
                    try
                    {
                        return PredictDemandForDayWithLbfgsPoissonRegression(product);
                    }
                    catch
                    {
                        return new ProcessOutput() { Product = new Product() { Code = "Exception occured" } };
                    }
                case PredictionAlgorithm.SDCA:
                    try
                    {
                        return PredictDemandForDayWithSdca(product);
                    }
                    catch
                    {
                        return new ProcessOutput() { Product = new Product() { Code = "Exception occured" } };
                    }
            }

            return null;
        }

        private ProcessOutput PredictDemandForDayWithFastTreeTweedie(Product product)
        {
            // check if data is valid
            if (product.Code == null || product.Sales == null)
            {
                return null;
            }
            else if (product.Sales.Count < 1)
            {
                return null;
            }

            MLContext mlContext = new MLContext();

            // 1. Import or create training data
            Sold[] sold = product.Sales.ToArray();
            IDataView trainingData = mlContext.Data.LoadFromEnumerable(sold);

            // 2. Specify data preparation and model training pipeline
            var pipeline = mlContext.Transforms.Concatenate("Features", "Day", "Month", "Year")
                .Append(mlContext.Regression.Trainers.FastTreeTweedie(labelColumnName: "Quantity"));

            // 3. Train model
            var model = pipeline.Fit(trainingData);

            return Predict(product, model, mlContext);
        }

        private ProcessOutput PredictDemandForDayWithFastForest(Product product)
        {
            // check if data is valid
            if (product.Code == null || product.Sales == null)
            {
                return null;
            }
            else if (product.Sales.Count < 1)
            {
                return null;
            }

            MLContext mlContext = new MLContext();

            // 1. Import or create training data
            Sold[] sold = product.Sales.ToArray();
            IDataView trainingData = mlContext.Data.LoadFromEnumerable(sold);

            // 2. Specify data preparation and model training pipeline
            var pipeline = mlContext.Transforms.Concatenate("Features", "Day", "Month", "Year")
                .Append(mlContext.Regression.Trainers.FastForest(labelColumnName: "Quantity"));

            // 3. Train model
            var model = pipeline.Fit(trainingData);

            return Predict(product, model, mlContext);
        }

        private ProcessOutput PredictDemandForDayWithLbfgsPoissonRegression(Product product)
        {
            // check if data is valid
            if (product.Code == null || product.Sales == null)
            {
                return null;
            }
            else if (product.Sales.Count < 1)
            {
                return null;
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

            return Predict(product, model, mlContext);
        }

        private ProcessOutput PredictDemandForDayWithSdca(Product product)
        {
            // check if data is valid
            if (product.Code == null || product.Sales == null)
            {
                return null;
            }
            else if (product.Sales.Count < 1)
            {
                return null;
            }

            MLContext mlContext = new MLContext();

            // 1. Import or create training data
            Sold[] sold = product.Sales.ToArray();
            IDataView trainingData = mlContext.Data.LoadFromEnumerable(sold);

            // 2. Specify data preparation and model training pipeline
            var pipeline = mlContext.Transforms.Concatenate("Features", "Day", "Month", "Year")
                .Append(mlContext.Regression.Trainers.Sdca(labelColumnName: "Quantity", maximumNumberOfIterations:10));

            // 3. Train model
            var model = pipeline.Fit(trainingData);

            return Predict(product, model, mlContext);
        }

        private ProcessOutput Predict(Product product, ITransformer model, MLContext mlContext)
        {
            float inventory = product.Inventory;

            float num = 1; // the number of days until stockout
            DateTime now = DateTime.Now;
            float totalSales = 0;
            while (inventory > 0)
            {
                // 4. Make a prediction
                DateTime newDateTime = now.AddDays(num);
                var salesOnDay = new Sold();
                salesOnDay.Day = newDateTime.Day;
                salesOnDay.Month = newDateTime.Month;
                salesOnDay.Year = newDateTime.Year;

                // making a prediction and saving the result to unitsSold
                var unitsSold = mlContext.Model.CreatePredictionEngine<Sold, Result>(model).Predict(salesOnDay);
                // updating inventory on hand
                inventory -= unitsSold.UnitsSold;

                totalSales += unitsSold.UnitsSold;
                num++;
            }

            float dailySales = totalSales / num; // daily sales = total sales / number of days

            num--;
            float result = num - product.LeadTime;

            // generating results
            ProcessOutput processOutput = new ProcessOutput();
            processOutput.Product = product;
            processOutput.DaysToOrder = result;
            processOutput.DailySales = dailySales;

            // predict sales for the next four months
            processOutput.PredictedMonthlySales[0] = PredictSalesForMonth(0, model, mlContext);
            processOutput.PredictedMonthlySales[1] = PredictSalesForMonth(30, model, mlContext);
            processOutput.PredictedMonthlySales[2] = PredictSalesForMonth(60, model, mlContext);
            processOutput.PredictedMonthlySales[3] = PredictSalesForMonth(90, model, mlContext);

            return processOutput;
        }

        private float PredictSalesForMonth(int days, Microsoft.ML.ITransformer model, MLContext mlContext)
        {
            float total = 0;

            for (int i = 1 + days; i < 31 + days; i++)
            {
                // update data
                DateTime newDateTime = DateTime.Now.AddDays(i);
                var salesOnDay = new Sold()
                {
                    Day = newDateTime.Day,
                    Month = newDateTime.Month,
                    Year = newDateTime.Year
                };

                // making a prediction and saving the result to unitsSold
                var unitsSold = mlContext.Model.CreatePredictionEngine<Sold, Result>(model).Predict(salesOnDay);
                total += unitsSold.UnitsSold;
            }

            return total;
        }
    }
}
