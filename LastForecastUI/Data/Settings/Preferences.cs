using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;
using Forecast;
using ForecastLibrary;

namespace LastForecastUI.Data
{
    public class Preferences : IPreferences
    {
        public RadzenGrid<ProcessOutput> Table { get; set; }
    }
}
