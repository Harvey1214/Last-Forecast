using System;
using System.Collections.Generic;
using System.Text;
using Forecast;

namespace ForecastLibrary
{
    public class Average : Predictor
    {
        public Average() { }
        public Average(Product product)
        {
            Product = product;
        }

        protected override ProcessOutput Calculate()
        {
            ProcessOutput processOutput = new ProcessOutput();
            processOutput.Product = Product;

            processOutput.DailySales = DailySales();
            processOutput.DaysToOrder = (float)DaysUntilStockout(processOutput.DailySales);

            for (int i = 0; i < processOutput.PredictedMonthlySales.Count; i++)
            {
                processOutput.PredictedMonthlySales[i] = processOutput.MonthlySales;
            }

            return processOutput;
        }

        private Single DailySales()
        {
            Single sum = 0;

            float highestDate = 0;
            float lowestDate = int.MaxValue;

            foreach (var sale in Product.Sales)
            {
                sum += sale.Quantity;

                if (sale.DayDate > highestDate)
                {
                    highestDate = sale.DayDate;
                }
                if (sale.DayDate < lowestDate)
                {
                    lowestDate = sale.DayDate;
                }
            }

            float count = 1;
            if (Sold.DayToNum(DateTime.Now) > lowestDate)
            {
                count += Sold.DayToNum(DateTime.Now) - lowestDate;
            }
            else
            {
                count = 1;
            }
            Single result = sum / count;

            return result;
        }
    }
}
