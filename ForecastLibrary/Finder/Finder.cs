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

        public Finder() { }
        public Finder(Product product)
        {
            Product = product;
        }

        private ForecastingManager ForecastingManager { get; set; } = new ForecastingManager();

        public ProcessOutput Find()
        {
            TestingProduct = new Product() { LeadTime = 0, Inventory = 0 };
            TestingProduct.Sales = Product.Sales.Where(o => o.Date < DateTime.Now.AddMonths(-1)).ToList();

            var lastMonthSales = Product.Sales.Where(o => o.Date > DateTime.Now.AddMonths(-1)).ToList();
            foreach (var sale in lastMonthSales)
            {
                CorrectMonthSales += sale.Quantity;
            }

            float algorithmsCount = 10;

            List<float> errors = new List<float>();
            for (int i = 0; i < algorithmsCount; i++)
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

            int lowestErrorIndex = 0;
            float lowestError = float.MaxValue;
            for (int j = 0; j < algorithmsCount; j++)
            {
                if (errors[j] < lowestError)
                {
                    lowestError = errors[j];
                    lowestErrorIndex = j;
                }
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
    }
}
