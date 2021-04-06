using System;
using System.Collections.Generic;
using System.Text;
using Forecast;
using System.Linq;

namespace ForecastLibrary
{
    public class ExponentialSmoothing : Predictor
    {
        public ExponentialSmoothing() { }
        public ExponentialSmoothing(Product product)
        {
            Product = product;
        }

        protected override ProcessOutput Calculate()
        {
            ProcessOutput processOutput = new ProcessOutput();
            processOutput.Product = Product;

            processOutput.DailySales = DailySales(0.04f, Product.Sales).result; // 0.05f is an alternative
            processOutput.DaysToOrder = (float)DaysUntilStockout(processOutput.DailySales);

            for (int i = 0; i < processOutput.PredictedMonthlySales.Count; i++)
            {
                processOutput.PredictedMonthlySales[i] = processOutput.MonthlySales;
            }

            return processOutput;
        }

        private float FindA()
        {
            float bestError = float.MaxValue;
            float optimalA = 0;

            float a = 0;
            while (a <= 1)
            {
                float error = DailySales(a, Product.Sales).meanError;

                if (error < bestError)
                {
                    optimalA = a;
                    bestError = error;
                }

                a += 0.01f;
            }

            return optimalA;
        }

        private (float result, float meanError) DailySales(float a, List<Sold> sales)
        {
            float previousForecast = 0;

            bool firstRecord = true;

            sales.OrderBy(o => o.Date);

            DateTime currentDate = DateTime.MaxValue;

            float errorSum = 0;
            float errorRecordCount = 0;

            foreach (var sale in sales)
            {
                if (sale.Date < currentDate)
                {
                    currentDate = sale.Date;
                }
            }

            while (currentDate < DateTime.Now)
            {
                if (firstRecord)
                {
                    Sold sold = sales.Where(o => o.Date == currentDate).ToList().First();
                    previousForecast = sold.Quantity;

                    firstRecord = false;
                }
                else
                {
                    var list = sales.Where(o => o.Date == currentDate).ToList();

                    if (list == null)
                    {
                        list = new List<Sold>();
                    }

                    if (list.Count == 0)
                    {
                        Sold sold = new Sold() { Quantity = 0 };
                        list.Add(sold);
                    }

                    float forecast = a * list.First().Quantity + (1 - a) * previousForecast;
                    previousForecast = forecast;

                    if (list.First().Quantity > 0)
                    {
                        errorSum += Math.Abs(forecast - list.First().Quantity);
                        errorRecordCount++;
                    }
                }

                currentDate = currentDate.AddDays(1);
            }

            return (result: previousForecast, meanError: errorSum / errorRecordCount);
        }
    }
}
