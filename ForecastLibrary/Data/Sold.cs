using ForecastLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    public class Sold : ISold
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

        public static string NonStandardDateFormat { get; set; } = "yyyy-MM-dd";

        public static bool StandardDate { get; set; } = true;

        public void SetDay(string date)
        {
            DateText = date;

            DateTime dateToSave = new DateTime();

            if (StandardDate)
                dateToSave = GetDateStandard(date);
            else
                dateToSave = GetDateSpecific(date);

            DayDate = DayToNum(date);

            Day = dateToSave.Day;
            Month = dateToSave.Month;
            Year = dateToSave.Year;
        }

        private static DateTime GetDateStandard(string dateAsText)
        {
            DateTime result = DateTime.Now;

            DateTime.TryParse(dateAsText, out result);

            return result;
        }

        private static DateTime GetDateSpecific(string textDate)
        {
            DateTime result = DateTime.Now;

            DateTime.TryParseExact(textDate, NonStandardDateFormat, null, System.Globalization.DateTimeStyles.None, out result);

            return result;

            /*DateTime result = new DateTime();

            string[] splitDate = textDate.Split('-');
            if (splitDate.Length == 3)
            {
                result = result.AddDays(GetDateAddition(splitDate[2]));
                result = result.AddMonths(GetDateAddition(splitDate[1]));
                result = result.AddYears(GetDateAddition(splitDate[0]));
            }

            return result;*/
        }

        private static int GetDateAddition(string text)
        {
            int result = 0;
            Int32.TryParse(text, out result);

            return result - 1;
        }

        #region DayNum
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

            DateTime dt = new DateTime();

            if (StandardDate)
                dt = GetDateStandard(date);
            else
                dt = GetDateSpecific(date);

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
        #endregion DayNum
    }
}
