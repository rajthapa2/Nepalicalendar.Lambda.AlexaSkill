using System;
using Xunit;
using NSubstitute;
using Shouldly;
using NepaliCalendar.Lambda.AlexaSkill.Services;
using TimeZoneConverter;


namespace Nepalicalendar.Lambda.AlexaSkill.Tests
{
    public class NepaliCalendarServiceTests
    {
        [Theory]
        [InlineData(2019, 09, 21, 00, 00, "Ashwin, 04, 2076")]
        [InlineData(2019, 09, 18, 00, 01, "Ashwin, 01, 2076")]
        [InlineData(2019, 09, 29, 01, 20, "Ashwin, 12, 2076")]
        [InlineData(2019, 10, 05, 01, 20, "Ashwin, 18, 2076")]
        [InlineData(2019, 10, 25, 01, 20, "Kartik, 08, 2076")]
        [InlineData(2019, 12, 14, 01, 20, "Mangshir, 28, 2076")]
        [InlineData(2019, 12, 21, 01, 20, "Poush, 05, 2076")]
        [InlineData(2020, 03, 21, 01, 20, "Chaitra, 08, 2076")]
        [InlineData(2020, 03, 13, 01, 20, "Falgun, 30, 2076")]
        [InlineData(2019, 11, 30, 01, 20, "Mangshir, 14, 2076")]
        [InlineData(2019, 12, 01, 01, 20, "Mangshir, 15, 2076")]
        [InlineData(2019, 12, 02, 01, 20, "Mangshir, 16, 2076")]
        [InlineData(2019, 12, 06, 23, 59, "Mangshir, 20, 2076")]
        [InlineData(2019, 12, 11, 23, 59, "Mangshir, 25, 2076")]
        [InlineData(2019, 12, 15, 23, 59, "Mangshir, 29, 2076")]
        [InlineData(2019, 12, 16, 04, 59, "Mangshir, 30, 2076")]
        [InlineData(2020, 01, 14, 03, 59, "Poush, 29, 2076")]
        [InlineData(2020, 02, 08, 02, 59, "Magh, 25, 2076")]
        [InlineData(2020, 01, 31, 22, 59, "Magh, 17, 2076")]
        [InlineData(2019, 12, 31, 21, 59, "Poush, 15, 2076")]
        [InlineData(2020, 01, 01, 20, 59, "Poush, 16, 2076")]
        [InlineData(2020, 01, 15, 23, 59, "Magh, 01, 2076")]
        [InlineData(2020, 04, 13, 23, 59, "Baishak, 01, 2077")]
        [InlineData(2022, 10, 25, 23, 59, "Kartik, 08, 2079")]
        [InlineData(2020, 05, 29, 23, 59, "Jestha, 16, 2077")]

        public void Get_nepaliDate_in_future(int year, int month, int day, int hour, int minutes, string expected)
        {
            var dateTimeService = Substitute.For<ISystemTime>();

            var  mockDate = new DateTime(year, month, day, hour, minutes, 00);
            dateTimeService.GetDateTime().Returns(mockDate);

            var calendarService = new NepaliCalendarService(dateTimeService);
            string nepaliDate = calendarService.GetNepaliDate(mockDate);

            nepaliDate.ShouldBe(expected);
        }

        [Theory]
        [InlineData(2019, 09, 17, "Bhadra, 31, 2076")]
        [InlineData(2019, 09, 16, "Bhadra, 30, 2076")]
        [InlineData(2019, 08, 18, "Bhadra, 01, 2076")]
        [InlineData(2019, 08, 17, "Shrawan, 32, 2076")]
        [InlineData(2019, 07, 16, "Ashad, 31, 2076")]
        [InlineData(2019, 06, 29, "Ashad, 14, 2076")]
        [InlineData(2019, 04, 13, "Chaitra, 30, 2075")]
        [InlineData(1989, 02, 07, "Magh, 25, 2045")]
        public void Get_nepaliDate_in_past(int year, int month, int day, string expected)
        {
            var dateTimeService = Substitute.For<ISystemTime>();

            var mockDate = new DateTime(year, month, day);
            dateTimeService.GetDateTime().Returns(mockDate);

            var calendarService = new NepaliCalendarService(dateTimeService);
            string nepaliDate = calendarService.GetNepaliDate(mockDate);

            nepaliDate.ShouldBe(expected);
        }

        [Fact]
        public void Get_nepaliDate_With_DateInfo()
        {
            var info = TZConvert.GetTimeZoneInfo("Nepal Standard Time");
            DateTimeOffset localServerTime = DateTimeOffset.Now;
            DateTimeOffset localTime = TimeZoneInfo.ConvertTime(localServerTime, info);

            var dateTimeService = Substitute.For<ISystemTime>();

            var mockDate = localTime.Date;
            dateTimeService.GetDateTime().Returns(mockDate);

            var calendarService = new NepaliCalendarService(dateTimeService);

            string nepaliDate = calendarService.GetNepaliDate(mockDate);

            nepaliDate.ShouldNotBe(null);
        }
    }
}
