namespace Nepalicalendar.Lambda.AlexaSkill.Services
{
    public class PositiveConterver : IDateConverter
    {
        public BCDate Convert(int daysDiff)
        {
            int newMonth = (int)BcDates.ReferenceBcDate.Month;
            int newYear = BcDates.ReferenceBcDate.Year;
            bool valid = true;

            daysDiff = BcDates.ReferenceBcDate.Day + daysDiff;

            while (valid)
            {
                int totalDays = BcDates.GetTotalDaysInMonth(newYear, (BCMonth)newMonth);
                // ash, kar, man, 
                // 30,  30, 30,   29,29,30,30
                if (daysDiff > totalDays)
                {
                    if (newMonth == 12)
                    {
                        newMonth = 0;
                        newYear = newYear + 1;
                    }
                    newMonth += 1;
                    daysDiff = daysDiff - totalDays;
                }
                else
                {
                    valid = false;
                }
            }
            var newDate = new BCDate(newYear, (BCMonth)newMonth, daysDiff);
            return newDate;
        }
    }
}
