﻿using Forecast;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForecastLibrary
{
    public class ProcessOutput
    {
        public Product Product { get; set; }
        public float DaysToOrder { get; set; }
        public float DailySales { get; set; }
    }
}
