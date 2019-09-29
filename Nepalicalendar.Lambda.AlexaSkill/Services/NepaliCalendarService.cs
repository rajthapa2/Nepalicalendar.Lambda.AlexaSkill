using System;

namespace Nepalicalendar.Lambda.AlexaSkill.Services
{
    public class NepaliCalendarService : INepaliCalendarService
    {
        public NepaliCalendarService(IDateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
        }
        public IDateTimeService _dateTimeService { get; }
        public string GetNepaliDate(DateTime date)
        {
            var daysDiff = Convert.ToInt32((date - BcDates.ReferenceAdDate).TotalDays);
            var dateConverter = BcDates.GetDateConverter(daysDiff);
            var newDate = dateConverter.Convert(daysDiff);
            return newDate.ToString();
        }
    }
}
