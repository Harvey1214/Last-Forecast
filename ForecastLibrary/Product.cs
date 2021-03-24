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
    }
}
