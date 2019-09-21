using System;

namespace Nepalicalendar.Lambda.AlexaSkill.Services
{
    public class NepaliCalendarService : INepaliCalendarService
    {
        public DateTime ReferenceAdDate { get; set; }
        public BCDate ReferenceBcDate { get; }
        public NepaliCalendarService(IDateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
            ReferenceAdDate = new DateTime(2019, 09, 21);
            ReferenceBcDate = new BCDate(2076, BCMonth.Ashwin, 04);
        }

        public IDateTimeService _dateTimeService { get; }

        public string GetNepaliDate(DateTime date)
        {
            var daysDiff = Convert.ToInt32((date - ReferenceAdDate).TotalDays);
            var nepaliBcDate = ReferenceBcDate;

            Console.WriteLine(daysDiff);
            var datesDiff = nepaliBcDate.Day + Convert.ToInt32(daysDiff);

            int totalDays = BcDates.GetTotalDaysInMonth(nepaliBcDate.Year, nepaliBcDate.Month);

            BCDate res;

            if(nepaliBcDate.Day + daysDiff > totalDays)
            {
                res = new BCDate(nepaliBcDate.Year, nepaliBcDate.Month + 1, datesDiff - totalDays);
            }
            else
            {
                nepaliBcDate.Day = nepaliBcDate.Day + Convert.ToInt32(daysDiff);
                res = nepaliBcDate;
            }

            //var newBcDate = GetBCFullDate(nepaliBcDate, datesDiff);

            return res.ToString();
            //return "04 Ashoj 2076";
        }
    }


    public enum BCMonth
    {
        Baishak = 1,
        Jestha = 2,
        Ashad = 3,
        Shrawan = 4,
        Bhadra = 5,
        Ashwin = 6,
        Kartik = 7,
        Mangshir = 8,
        Poush = 9,
        Magh = 10,
        Falgun = 11,
        Chaitra = 12,
    }

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
