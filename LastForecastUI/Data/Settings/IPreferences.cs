using ForecastLibrary;
using Radzen.Blazor;

namespace LastForecastUI.Data
{
    public interface IPreferences
    {
        RadzenGrid<ProcessOutput> Table { get; set; }
    }
}