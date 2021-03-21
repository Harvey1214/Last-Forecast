using System;
using System.Collections.Generic;
using System.Text;
using Forecast;

namespace ForecastLibrary
{
    public class Predictor : IPredictor
    {
        protected Product Product { get; set; }

        public Predictor() { }
        public Predictor(Product product)
        {
            Product = product;
        }

        public ProcessOutput Predict()
        {
            if (Product != null)
            {
                return Calculate();
            }
            else
            {
                return null;
            }
        }
        protected virtual ProcessOutput Calculate()
        {
            throw new MissingMethodException();
        }
    }
}
