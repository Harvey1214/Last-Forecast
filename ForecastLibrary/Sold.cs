using ForecastLibrary;
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

        /// <summary>
        /// Date stored as the original text for debugging purposes
        /// </summary>
        public string DateText { get; set; }

        private const string StartDate = "1/1/1998";

        public void SetDay(string date, DateSettings dateSettings)
        {
            DateText = date;

            DateTime dateToSave;
            bool success = false;
            if (dateSettings == DateSettings.US)
            {
                success = DateTime.TryParse(date, out dateToSave);

                DayDate = DayToNum(date);
            }
            else
            {
                success = GetCzechDate(date, out dateToSave);

                if (success)
                    DayDate = DayToNum(dateToSave);
            }

            if (success)
            {
                Day = dateToSave.Day;
                Month = dateToSave.Month;
                Year = dateToSave.Year;
            }
        }

        private bool GetCzechDate(string date, out DateTime dt)
        {
            try
            {
                string[] splitDate = date.Split('.');

                DateTime dateTime = new DateTime();
                dateTime.AddDays(Int32.Parse(splitDate[0]));
                dateTime.AddMonths(Int32.Parse(splitDate[1]));
                dateTime.AddYears(Int32.Parse(splitDate[2]));

                dt = dateTime;
                return true;
            }
            catch
            {
                dt = new DateTime();
                return false;
            }
        }

        public static int DayToNumUpgraded(string date)
        {
            DateTime dt;
            DateTime.TryParse(date, out dt);

            int days = 0;
            days += dt.Day;
            days += Convert.ToInt32(dt.Month * 30.3);
            days += dt.Year * 365;

            return days;
        }

        public static int DayToNum(string date)
        {
            DateTime start = DateTime.Parse(StartDate);
            DateTime dt;

            DateTime.TryParse(date, out dt);
            TimeSpan t = dt - start;
            return (int)t.TotalDays;
        }

        public static int DayToNum(DateTime date)
        {
            DateTime start = DateTime.Parse(StartDate);
            TimeSpan t = date - start;
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
