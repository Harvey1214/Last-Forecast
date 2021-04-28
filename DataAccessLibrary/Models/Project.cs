using System;
using System.Collections.Generic;
using System.Text;
using Forecast;
using ForecastLibrary;

namespace DataAccessLibrary
{
    public class Project
    {
        #region Administration
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        #endregion

        #region Import
        public char SplitBy { get; set; }

        /// <summary>
        /// Positions of the data columns in the inventory file
        /// </summary>
        public int ProductIdColumnInInventory { get; set; }
        public int ProductTitleColumn { get; set; }
        public int VariantTitleColumn { get; set; }
        public int InventoryOnHandColumn { get; set; }
        public int LeadTimeColumn { get; set; }

        /// <summary>
        /// Positions of the data columns in the sales file
        /// </summary>
        public int ProductIdColumnInSales { get; set; }
        public int DateColumn { get; set; }
        public int UnitsSoldColumn { get; set; }

        public bool StandardDate { get; set; } = true;
        public string NonStandardDateFormat { get; set; }
        #endregion Import

        #region Forecast
        public PredictionAlgorithm PredictionAlgorithm { get; set; } = PredictionAlgorithm.AUTOALL;
        public PredictionAlgorithm MLPredictionAlgorithm { get; set; } = PredictionAlgorithm.LBFGSPOISSONREGRESSION;
        public PredictionAlgorithm SafePredictionAlgorithm { get; set; } = PredictionAlgorithm.EXPONENTIALSMOOTHING;

        public int SalesThreshold { get; set; } = 150;
        public bool AutoLeadTime { get; set; } = true;
        #endregion Forecast
    }
}
