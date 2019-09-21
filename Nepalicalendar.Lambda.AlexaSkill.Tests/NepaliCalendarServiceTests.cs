using System;
using Xunit;
using NSubstitute;
using Shouldly;
using Nepalicalendar.Lambda.AlexaSkill.Services;


namespace Nepalicalendar.Lambda.AlexaSkill.Tests
{
    public class NepaliCalendarServiceTests //: IClassFixture<NepaliCalendarFixture>
    {
        //private readonly NepaliCalendarFixture _calendarFixture;
        //public NepaliCalendarServiceTests(NepaliCalendarFixture calendarFixture)
        //{
        //    _calendarFixture = calendarFixture;
        //}

        [Theory]
        [InlineData(2019, 09, 21, "04 Ashwin 2076")]
        [InlineData(2019, 09, 18, "01 Ashwin 2076")]
        [InlineData(2019, 09, 29, "12 Ashwin 2076")]
        //[InlineData(2019, 09, 17, "31 Bhadra 2076")]
        [InlineData(2019, 10, 05, "18 Ashwin 2076")]
        [InlineData(2019, 10, 25, "08 Kartik 2076")]
        //[InlineData(2019, 12, 14, "28 Mangshir 2076")]
        public void Get_nepaliDate(int year, int month, int day, string expected)
        {
            var dateTimeService = Substitute.For<IDateTimeService>();

            var  mockDate = new DateTime(year, month, day);
            dateTimeService.GetDateTime().Returns(mockDate);

            var calendarService = new NepaliCalendarService(dateTimeService);
            string nepaliDate = calendarService.GetNepaliDate(mockDate);

            nepaliDate.ShouldBe(expected);
        }
    }
}
