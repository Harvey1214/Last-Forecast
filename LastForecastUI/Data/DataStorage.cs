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
    }
}
