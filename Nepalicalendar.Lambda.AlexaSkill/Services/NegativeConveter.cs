using System;

namespace Nepalicalendar.Lambda.AlexaSkill.Services
{
    public class NegativeConveter : IDateConverter
    {
        public BCDate Convert(int daysDiff)
        {
            daysDiff = Math.Abs(daysDiff);
            var currentDate = BcDates.ReferenceBcDate.Day;
            var newDate = 0;
            var newMonth = BcDates.ReferenceBcDate.Month;
            var valid = true;
            var newYear = BcDates.ReferenceBcDate.Year;
            while (valid)
            {
                if (currentDate > daysDiff)
                {
                    newDate = currentDate - daysDiff;
                    valid = false;
                }
                else
                {
                    newMonth -= 1;
                    if(newMonth == 0)
                    {
                        newMonth = BCMonth.Chaitra;
                        newYear = newYear - 1;
                    }
                    int previousMonthDate = BcDates.GetTotalDaysInMonth(newYear, (BCMonth)newMonth);
                    
                    daysDiff = daysDiff - currentDate;
                    currentDate = previousMonthDate;
                }
            }

            var newDate1 = new BCDate(newYear, newMonth, Math.Abs(newDate));
            return newDate1;
        }
    }
}
