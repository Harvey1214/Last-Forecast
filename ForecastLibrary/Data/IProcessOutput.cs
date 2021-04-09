using Forecast;
using System.Collections.Generic;

namespace ForecastLibrary
{
    public interface IProcessOutput
    {
        float DailySales { get; set; }
        float DaysToOrder { get; set; }
        float MonthlySales { get; }
        List<float> PredictedMonthlySales { get; set; }
        Product Product { get; set; }
        PredictionAlgorithm PredictionAlgorithm { get; set; }
    }
}