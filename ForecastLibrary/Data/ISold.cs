namespace Forecast
{
    public interface ISold
    {
        string DateText { get; set; }
        float Day { get; set; }
        float DayDate { get; set; }
        float Month { get; set; }
        float Quantity { get; set; }
        float Year { get; set; }

        void SetDay(string date);
    }
}