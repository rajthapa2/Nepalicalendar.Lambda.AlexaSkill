namespace Nepalicalendar.Lambda.AlexaSkill.Services
{
    public class BCDate
    {
        public int Day { get; set; }
        public BCMonth Month { get; set; }
        public int Year { get; set; }

        public BCDate(int year, BCMonth month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public override string ToString()
        {
            return $"{Day.ToString("00")} {Month} {Year}";
        }
    }
}
