using System;
using Xunit;
using NSubstitute;
using Shouldly;
using Nepalicalendar.Lambda.AlexaSkill.Services;


namespace Nepalicalendar.Lambda.AlexaSkill.Tests
{
    public class NepaliCalendarServiceTests
    {
        [Theory]
        [InlineData(2019, 09, 21, "04 Ashwin 2076")]
        [InlineData(2019, 09, 18, "01 Ashwin 2076")]
        [InlineData(2019, 09, 29, "12 Ashwin 2076")]
        [InlineData(2019, 10, 05, "18 Ashwin 2076")]
        [InlineData(2019, 10, 25, "08 Kartik 2076")]
        [InlineData(2019, 12, 14, "28 Mangshir 2076")]
        [InlineData(2019, 12, 21, "05 Poush 2076")]
        [InlineData(2020, 03, 21, "08 Chaitra 2076")]
        [InlineData(2020, 03, 13, "30 Falgun 2076")]
        [InlineData(2019, 11, 30, "14 Mangshir 2076")]
        [InlineData(2019, 12, 01, "15 Mangshir 2076")]
        [InlineData(2019, 12, 02, "16 Mangshir 2076")]
        [InlineData(2019, 12, 06, "20 Mangshir 2076")]
        [InlineData(2019, 12, 11, "25 Mangshir 2076")]
        [InlineData(2019, 12, 15, "29 Mangshir 2076")]
        [InlineData(2019, 12, 16, "30 Mangshir 2076")]
        [InlineData(2020, 01, 14, "29 Poush 2076")]
        [InlineData(2020, 02, 08, "25 Magh 2076")]
        [InlineData(2020, 01, 31, "17 Magh 2076")]
        [InlineData(2019, 12, 31, "15 Poush 2076")]
        [InlineData(2020, 01, 01, "16 Poush 2076")]
        [InlineData(2020, 01, 15, "01 Magh 2076")]
        [InlineData(2020, 04, 13, "01 Baishak 2077")]
        [InlineData(2022, 10, 25, "08 Kartik 2079")]
        public void Get_nepaliDate_in_future(int year, int month, int day, string expected)
        {
            var dateTimeService = Substitute.For<IDateTimeService>();

            var  mockDate = new DateTime(year, month, day);
            dateTimeService.GetDateTime().Returns(mockDate);

            var calendarService = new NepaliCalendarService(dateTimeService);
            string nepaliDate = calendarService.GetNepaliDate(mockDate);

            nepaliDate.ShouldBe(expected);
        }

        [Theory]
        [InlineData(2019, 09, 17, "31 Bhadra 2076")]
        [InlineData(2019, 09, 16, "30 Bhadra 2076")]
        [InlineData(2019, 08, 18, "01 Bhadra 2076")]
        [InlineData(2019, 08, 17, "32 Shrawan 2076")]
        [InlineData(2019, 07, 16, "31 Ashad 2076")]
        [InlineData(2019, 06, 29, "14 Ashad 2076")]
        [InlineData(2019, 04, 13, "30 Chaitra 2075")]
        [InlineData(1989, 02, 07, "25 Magh 2045")]
        public void Get_nepaliDate_in_past(int year, int month, int day, string expected)
        {
            var dateTimeService = Substitute.For<IDateTimeService>();

            var mockDate = new DateTime(year, month, day);
            dateTimeService.GetDateTime().Returns(mockDate);

            var calendarService = new NepaliCalendarService(dateTimeService);
            string nepaliDate = calendarService.GetNepaliDate(mockDate);

            nepaliDate.ShouldBe(expected);
        }
    }
}
