using Nepalicalendar.Lambda.AlexaSkill.Services;
using System;

namespace Nepalicalendar.Lambda.AlexaSkill.Tests
{
    public class NepaliCalendarFixture : IDisposable
    {
        public NepaliCalendarService NepaliCalendarService { get; }
        public NepaliCalendarFixture()
        {
           
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
