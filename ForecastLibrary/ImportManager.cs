using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Forecast;
using System.Security.Cryptography;

namespace ForecastLibrary
{
    public class ImportManager
    {
        public string[] InventoryFileContent { get; set; }
        public string[] SalesFileContent { get; set; }

        public char SplitBy { get; set; }
        public string SalesFile { get; set; }
        public string InventoryFile { get; set; }
        public ForecastingManager ForecastingManager { get; set; }

        /// <summary>
        /// Positions of the data columns in the inventory file
        /// </summary>
        public int ProductIdColumnInInventory { get; set; }
        public int InventoryOnHandColumn { get; set; }
        public int LeadTimeColumn { get; set; }

        /// <summary>
        /// Positions of the data columns in the sales file
        /// </summary>
        public int ProductIdColumnInSales { get; set; }
        public int DateColumn { get; set; }
        public int UnitsSoldColumn { get; set; }

        public ImportManager(string salesFile = "", string inventoryFile = "", char splitBy = ',', ForecastingManager forecastingManager = null)
        {
            InventoryFile = inventoryFile;
            SalesFile = salesFile;
            SplitBy = splitBy;
            this.ForecastingManager = forecastingManager;
        }

        public bool ImportData(int productIdColumnInInventory = 0, int inventoryOnHandColumn = 0, int leadTimeColumn = 0, int productIdColumnInSales = 0, int dateColumn = 0, int unitsSoldColumn = 0)
        {
            // updating column positions
            ProductIdColumnInInventory = productIdColumnInInventory;
            InventoryOnHandColumn = inventoryOnHandColumn;
            LeadTimeColumn = leadTimeColumn;
            ProductIdColumnInSales = productIdColumnInSales;
            DateColumn = dateColumn;
            UnitsSoldColumn = unitsSoldColumn;

            // importing data
            try
            {
                ImportInventoryData();
                ImportSalesData();

                return true;
            }
            catch (NullReferenceException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void ImportInventoryData()
        {
            if (ForecastingManager == null || InventoryFileContent == null)
            {
                return;
            }

            List<List<string>> columns = GetColumns(InventoryFileContent);

            // first [] = no. of the needed column, for example product id, inventory, lead time, etc.
            // second [] = no. of the current row

            // finds the logest column's length
            int maxColumnLength = 0;
            foreach (List<string> column in columns)
            {
                if (column.Count > maxColumnLength)
                {
                    maxColumnLength = column.Count;
                }
            }

            // goes through all of the rows and adds the resulting products to ForecastingManager
            for (int i = 0; i < maxColumnLength; i++)
            {
                Product product = new Product();

                if (ProductIdColumnInInventory < columns.Count)
                    if (columns[ProductIdColumnInInventory].Count > i)
                        product.Code = columns[ProductIdColumnInInventory][i];

                if (InventoryOnHandColumn < columns.Count)
                    if (columns[InventoryOnHandColumn].Count > i)
                        product.Inventory = GetInt(columns[InventoryOnHandColumn][i]);

                if (LeadTimeColumn < columns.Count)
                    if (columns[LeadTimeColumn].Count > i)
                        product.LeadTime = GetInt(columns[LeadTimeColumn][i]);

                this.ForecastingManager.Products.Add(product);
            }
        }

        private void ImportSalesData()
        {
            if (ForecastingManager == null || SalesFileContent == null)
            {
                return;
            }

            List<List<string>> columns = GetColumns(SalesFileContent);

            // finds the logest column's length
            int maxColumnLength = 0;
            foreach (List<string> column in columns)
            {
                if (column.Count > maxColumnLength)
                {
                    maxColumnLength = column.Count;
                }
            }

            // goes through all of the rows, finds the product and adds the sales to it
            for (int i = 0; i < maxColumnLength; i++)
            {
                foreach (Product product in ForecastingManager.Products)
                {
                    if (product.Code == columns[ProductIdColumnInSales][i])
                    {
                        Sold sold = new Sold();
                        sold.SetDay(columns[DateColumn][i], DateSettings.US);
                        sold.Quantity = GetInt(columns[UnitsSoldColumn][i]);
                        product.Sales.Add(sold);
                    }
                }
            }
        }

        /// <summary>
        /// Converts all the columns in a file to a list of lists of strings
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        private List<List<string>> GetColumns(string[] lines)
        {
            List<List<string>> columns = new List<List<string>>();
            foreach (string line in lines)
            {
                string[] currentColumns = line.Split(SplitBy);

                for (int i = 0; i < currentColumns.Length; i++)
                {
                    if (i < columns.Count)
                    {
                        columns[i].Add(currentColumns[i]);
                    }
                    else
                    {
                        columns.Add(new List<string>());
                        columns[i].Add(currentColumns[i]);
                    }
                }
            }

            return columns;
        }

        private int GetInt(string number)
        {
            int result = 0;
            bool success = Int32.TryParse(number, out result);

            return result;
        }
    }
}
