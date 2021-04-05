using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    public class Product
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string VariantTitle { get; set; }
        public List<Sold> Sales { get; set; } = new List<Sold>();
        public int Inventory { get; set; }
        public int LeadTime { get; set; }
        public Single MonthToDateSales
        {
            get
            {
                Single result = 0;

                var monthToDateSales = Sales.Where(o => o.Month == DateTime.Now.Month && o.Year == DateTime.Now.Year);
                foreach (var sale in monthToDateSales)
                {
                    result += sale.Quantity;
                }

                return result;
            }
        }
        public Single LastMonthSales
        {
            get
            {
                Single result = 0;

                var lastMonthSales = Sales.Where(o => (o.Month == DateTime.Now.Month - 1) && o.Year == DateTime.Now.Year);
                foreach (var sale in lastMonthSales)
                {
                    result += sale.Quantity;
                }

                return result;
            }
        }
    }
}
