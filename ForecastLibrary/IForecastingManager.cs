using ForecastLibrary;
using System.Collections.Generic;

namespace Forecast
{
    public interface IForecastingManager
    {
        bool AutoLeadTime { get; set; }
        string FileName { get; set; }
        PredictionAlgorithm MLPredictionAlgorithm { get; set; }
        PredictionAlgorithm PredictionAlgorithm { get; set; }
        List<Product> Products { get; set; }
        List<ProcessOutput> Results { get; set; }
        PredictionAlgorithm SafePredictionAlgorithm { get; set; }
        int SalesThreshold { get; set; }
        string SeparatorCharacter { get; set; }

        ProcessOutput FindLatestOrderDay(Product product, PredictionAlgorithm predictionAlgorithm);
        List<ProcessOutput> FindLatestOrderDays();
    }
}