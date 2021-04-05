using System.Collections.Generic;

namespace LastForecastUI.Data
{
    public interface IComparisonHandler
    {
        List<Comparison> Comparisons { get; set; }
    }
}