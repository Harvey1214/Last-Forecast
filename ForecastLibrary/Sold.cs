using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    public class Sold
    {
        public Single DayDate { get; set; } = 0;
        private Single quantity = 0;
        public Single Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value >= 0)
                {
                    quantity = value;
                }
                else
                {
                    quantity = 0;
                }
            }
        }

        public Single Day { get; set; } = 0;
        public Single Month { get; set; } = 0;
        public Single Year { get; set; } = 0;

        private const string StartDate = "1/1/1990";

        public void SetDay(string date)
        {
            Day = DayToNum(date);

            DateTime dateToSave;
            bool success = DateTime.TryParse(date, out dateToSave);

            if (success)
            {
                Day = dateToSave.Day;
                Month = dateToSave.Month;
                Year = dateToSave.Year;
            }
        }

        public static int DayToNum(string date)
        {
            DateTime start = DateTime.Parse(StartDate);
            DateTime dt;
            DateTime.TryParse(date, out dt);
            TimeSpan t = dt - start;
            return (int)t.TotalDays;
        }
        
        public static string NumToDay(int num)
        {
            DateTime startDate = DateTime.Parse(StartDate);
            startDate.AddDays(num);
            return startDate.ToString();
        }
    }
}
