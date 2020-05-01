using System;

namespace NepaliCalendar.Lambda.AlexaSkill.Services
{
    public class NepaliCalendarService : INepaliCalendarService
    {
        public ISystemTime SystemTime { get; }

        public NepaliCalendarService(ISystemTime systemTime)
        {
            SystemTime = systemTime;
        }

        public string GetNepaliDate(DateTime date)
        {
            var daysDiff = Convert.ToInt32((date - BcDates.ReferenceAdDate).TotalDays);
            var dateConverter = BcDates.GetDateConverter(daysDiff);
            var newDate = dateConverter.Convert(daysDiff);
            return newDate.ToString();
        }
    }
}
