using System.Collections.Generic;

namespace LastForecastUI.Data
{
    public interface IDataStorage
    {
        List<RawData> RawData { get; set; }
        State State { get; set; }

        List<string> GetFileNames();
    }
}