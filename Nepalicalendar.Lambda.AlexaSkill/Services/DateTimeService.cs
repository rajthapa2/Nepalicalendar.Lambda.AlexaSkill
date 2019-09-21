using System;

namespace Nepalicalendar.Lambda.AlexaSkill.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTimeService()
        {
        }

        public DateTime GetDateTime()
        {
            return DateTime.UtcNow;
        }
    }
}
