using System;

namespace NepaliCalendar.Lambda.AlexaSkill.Services
{
    public interface INepaliCalendarService
    {
        string GetNepaliDate(DateTime AdDate);
    }
}