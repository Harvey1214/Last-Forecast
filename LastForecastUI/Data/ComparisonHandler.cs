using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LastForecastUI.Data
{
    public class ComparisonHandler
    {
        public static int MaxId { get; set; }
        public List<Comparison> Comparisons { get; set; } = new List<Comparison>();
    }
}
