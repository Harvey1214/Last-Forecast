using System;
using System.Collections.Generic;
using System.Text;

namespace ForecastLibrary
{
    public enum PredictionAlgorithm
    {
        AVERAGE,
        MEDIAN,
        LINEARREGRESSION,
        FASTTREETWEEDIE,
        FASTFOREST,
        LBFGSPOISSONREGRESSION,
        SDCA,
        AUTO
    }
}
