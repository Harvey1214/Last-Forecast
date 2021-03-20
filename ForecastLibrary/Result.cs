using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForecastLibrary
{
    public class Result
    {
        [ColumnName("Score")]
        public float UnitsSold { get; set; }
    }
}
