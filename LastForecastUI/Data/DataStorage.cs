using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LastForecastUI.Data
{
    public class DataStorage
    {
        public List<RawData> RawData { get; set; } = new List<RawData>();
        internal State State = State.UPLOAD;

        public List<string> GetFileNames()
        {
            if (RawData.Count != 2)
            {
                return null;
            }

            return new List<string>() { RawData[0].Name, RawData[1].Name };
        }
    }
}
