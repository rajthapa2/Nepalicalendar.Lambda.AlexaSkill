using System;

namespace Nepalicalendar.Lambda.AlexaSkill.Services
{
    public class NegativeConveter : IDateConverter
    {
        //public BCDate Convert(int daysDiff)
        //{
        //    int newMonth = (int)BcDates.ReferenceBcDate.Month;
        //    int newYear = BcDates.ReferenceBcDate.Year;
        //    int newDay = 0;
        //    bool valid = true;
        //    int currentMonthDate = (int)BcDates.ReferenceBcDate.Day;
        //    int referenceDate = (int)BcDates.ReferenceBcDate.Day;

        //    var daysDiffPositive = daysDiff * -1;

        //    //  1  2  3  4  5  6  7  8  9  10 11  12
        //    // 31,31, 31,32,31,31,30,29,30,29, 30, 30
        //    while (valid)
        //    {
        //        if (Math.Abs(daysDiffPositive) - currentMonthDate < 0)
        //        {
        //            daysDiff = daysDiffPositive - currentMonthDate;
        //            valid = false;
        //        }
        //        else
        //        {
        //            newMonth -= 1;
        //            currentMonthDate = BcDates.GetTotalDaysInMonth(newYear, (BCMonth)newMonth);
        //            daysDiff = currentMonthDate - (daysDiffPositive - referenceDate);
        //        }

        //        if(daysDiff == 0)
        //        {
        //            valid = false;
        //            newMonth -= 1;
        //            currentMonthDate = BcDates.GetTotalDaysInMonth(newYear, (BCMonth)newMonth);
        //            daysDiff = currentMonthDate;
        //        }

        //        if (Math.Abs(daysDiff) <= currentMonthDate)
        //        {
        //            valid = false;
        //        }
        //        referenceDate = 0;
        //        daysDiffPositive = Math.Abs(daysDiff);
        //    }

        //    var newDate = new BCDate(newYear, (BCMonth)newMonth, Math.Abs(daysDiff));
        //    return newDate;
        //}
        public BCDate Convert(int daysDiff)
        {
            daysDiff = Math.Abs(daysDiff);
            var currentDate = BcDates.ReferenceBcDate.Day;
            var newDate = 0;
            var newMonth = BcDates.ReferenceBcDate.Month;
            var valid = true;
            var previousMonthDate = 0;
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
                    previousMonthDate = BcDates.GetTotalDaysInMonth(newYear, (BCMonth)newMonth); ;
                    daysDiff = daysDiff - currentDate;
                    currentDate = previousMonthDate;
                }
            }

            var newDate1 = new BCDate(newYear, (BCMonth)newMonth, Math.Abs(newDate));
            return newDate1;
        }
    }
}
