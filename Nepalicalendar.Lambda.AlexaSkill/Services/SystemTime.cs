using System;

namespace NepaliCalendar.Lambda.AlexaSkill.Services
{
    public class SystemTime : ISystemTime
    {
        public SystemTime()
        {
        }

        public DateTime GetDateTime()
        {
            return DateTime.UtcNow;
        }
    }
}
