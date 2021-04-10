using System;
using System.Collections.Generic;
using System.Text;
using Forecast;
using System.Linq;

namespace ForecastLibrary
{
    public class Finder
    {
        public Product Product { get; set; }
        private Product TestingProduct { get; set; }

        private float CorrectMonthSales { get; set; }
        private float Volatility { get; set; }

        public Finder() { }
        public Finder(Product product)
        {
            Product = product;
        }

        private ForecastingManager ForecastingManager { get; set; } = new ForecastingManager();

        public ProcessOutput Find()
        {
            // initializing the testing product
            TestingProduct = new Product() { LeadTime = 0, Inventory = 0, Code = Product.Code };
            TestingProduct.Sales = Product.Sales.Where(o => o.Date < DateTime.Now.AddMonths(-2).AddDays(-DateTime.Now.Day)).ToList();

            // finding the sales volatility
            Volatility = CalculateSalesVolatility(Product.Sales);

            // finding the correct sales for the test month
            CorrectMonthSales = CalculateCorrectMonthSales(Product.Sales);
            float CalculateCorrectMonthSales(List<Sold> sales)
            {
                float correctMonthSales = 0;

                var thisMonthSales = sales.Where(o => (o.Month == DateTime.Now.Month - 1) && o.Year == DateTime.Now.Year).ToList();
                foreach (var sale in thisMonthSales)
                {
                    correctMonthSales += sale.Quantity;
                }

                return correctMonthSales;
            }

            float algorithmsCountWithoutAUTOALL = 9;

            // predicting using all of the available algorithms and finding errors
            List<float> errors = new List<float>();
            {
                for (int i = 0; i < algorithmsCountWithoutAUTOALL; i++)
                {
                    float error = float.MaxValue;

                    try
                    {
                        error = CalculateError((PredictionAlgorithm)i);
                    }
                    catch
                    {

                    }

                    errors.Add(error);
                }
            }

            // finding the algorithm with lowest error
            int lowestErrorIndex = 0;
            float lowestError = float.MaxValue;
            {
                for (int j = 0; j < algorithmsCountWithoutAUTOALL; j++)
                {
                    if (errors[j] < lowestError)
                    {
                        lowestError = errors[j];
                        lowestErrorIndex = j;
                    }
                }
            }

            if ((PredictionAlgorithm)lowestErrorIndex == PredictionAlgorithm.AVERAGE)
            if (lowestError > (errors[(int)PredictionAlgorithm.EXPONENTIALSMOOTHING] * (1 - Volatility)))
            {
                return ForecastingManager.FindLatestOrderDay(Product, PredictionAlgorithm.EXPONENTIALSMOOTHING);
            }

            return ForecastingManager.FindLatestOrderDay(Product, (PredictionAlgorithm)lowestErrorIndex);
        }

        private float CalculateError(PredictionAlgorithm predictionAlgorithm)
        {
            ProcessOutput processOutput = ForecastingManager.FindLatestOrderDay(TestingProduct, predictionAlgorithm);

            if (processOutput == null)
            {
                return float.MaxValue;
            }

            return Math.Abs(processOutput.PredictedMonthlySales[0] - CorrectMonthSales);
        }

        private float CalculateSalesVolatility(List<Sold> sales)
        {
            float volatilitySum = 0f;
            float recordCount = sales.Count - 1;

            for (int i = 0; i < sales.Count; i++)
            {
                if (i + 1 >= sales.Count)
                {
                    continue;
                }

                if (sales[i].Quantity > sales[i + 1].Quantity)
                {
                    float volatility = sales[i].Quantity / sales[i + 1].Quantity;
                    volatility--;

                    volatilitySum += volatility;
                }
                else
                {
                    float volatility = sales[i + 1].Quantity / sales[i].Quantity;
                    volatility--;

                    volatilitySum += volatility;
                }
            }

            return volatilitySum / recordCount;
        }
    }
}
