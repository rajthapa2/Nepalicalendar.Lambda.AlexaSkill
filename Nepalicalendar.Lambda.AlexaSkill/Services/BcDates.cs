﻿using System.Collections.Generic;

namespace Nepalicalendar.Lambda.AlexaSkill.Services
{
    public class BcDates
    {
        private static Dictionary<int, List<int>> NepaliCalendarYearDays =
            new Dictionary<int, List<int>>()
            {
               {2000, new List<int> {30,32,31,32,31,30,30,30,29,30,29,31} },
                {2001, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2002, new List<int> {31,31,32,32,31,30,30,29,30,29,30,30} },
                {2003, new List<int> {31,32,31,32,31,30,30,30,29,29,30,31} },
                {2004, new List<int> {30,32,31,32,31,30,30,30,29,30,29,31} },
                {2005, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2006, new List<int> {31,31,32,32,31,30,30,29,30,29,30,30} },
                {2007, new List<int> {31,32,31,32,31,30,30,30,29,29,30,31} },
                {2008, new List<int> {31,31,31,32,31,31,29,30,30,29,29,31} },
                {2009, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2010, new List<int> {31,31,32,32,31,30,30,29,30,29,30,30} },
                {2011, new List<int> {31,32,31,32,31,30,30,30,29,29,30,31} },
                {2012, new List<int> {31,31,31,32,31,31,29,30,30,29,30,30} },
                {2013, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2014, new List<int> {31,31,32,32,31,30,30,29,30,29,30,30} },
                {2015, new List<int> {31,32,31,32,31,30,30,30,29,29,30,31} },
                {2016, new List<int> {31,31,31,32,31,31,29,30,30,29,30,30} },
                {2017, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2018, new List<int> {31,32,31,32,31,30,30,29,30,29,30,30} },
                {2019, new List<int> {31,32,31,32,31,30,30,30,29,30,29,31} },
                {2020, new List<int> {31,31,31,32,31,31,30,29,30,29,30,30} },
                {2021, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2022, new List<int> {31,32,31,32,31,30,30,30,29,29,30,30} },
                {2023, new List<int> {31,32,31,32,31,30,30,30,29,30,29,31} },
                {2024, new List<int> {31,31,31,32,31,31,30,29,30,29,30,30} },
                {2025, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2026, new List<int> {31,32,31,32,31,30,30,30,29,29,30,31} },
                {2027, new List<int> {30,32,31,32,31,30,30,30,29,30,29,31} },
                {2028, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2029, new List<int> {31,31,32,31,32,30,30,29,30,29,30,30} },
                {2030, new List<int> {31,32,31,32,31,30,30,30,29,29,30,31} },
                {2031, new List<int> {30,32,31,32,31,30,30,30,29,30,29,31} },
                {2032, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2033, new List<int> {31,31,32,32,31,30,30,29,30,29,30,30} },
                {2034, new List<int> {31,32,31,32,31,30,30,30,29,29,30,31} },
                {2035, new List<int> {30,32,31,32,31,31,29,30,30,29,29,31} },
                {2036, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2037, new List<int> {31,31,32,32,31,30,30,29,30,29,30,30} },
                {2038, new List<int> {31,32,31,32,31,30,30,30,29,29,30,31} },
                {2039, new List<int> {31,31,31,32,31,31,29,30,30,29,30,30} },
                {2040, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2041, new List<int> {31,31,32,32,31,30,30,29,30,29,30,30} },
                {2042, new List<int> {31,32,31,32,31,30,30,30,29,29,30,31} },
                {2043, new List<int> {31,31,31,32,31,31,29,30,30,29,30,30} },
                {2044, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2045, new List<int> {31,32,31,32,31,30,30,29,30,29,30,30} },
                {2046, new List<int> {31,32,31,32,31,30,30,30,29,29,30,31} },
                {2047, new List<int> {31,31,31,32,31,31,30,29,30,29,30,30} },
                {2048, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2049, new List<int> {31,32,31,32,31,30,30,30,29,29,30,30} },
                {2050, new List<int> {31,32,31,32,31,30,30,30,29,30,29,31} },
                {2051, new List<int> {31,31,31,32,31,31,30,29,30,29,30,30} },
                {2052, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2053, new List<int> {31,32,31,32,31,30,30,30,29,29,30,30} },
                {2054, new List<int> {31,32,31,32,31,30,30,30,29,30,29,31} },
                {2055, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2056, new List<int> {31,31,32,31,32,30,30,29,30,29,30,30} },
                {2057, new List<int> {31,32,31,32,31,30,30,30,29,29,30,31} },
                {2058, new List<int> {30,32,31,32,31,30,30,30,29,30,29,31} },
                {2059, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2060, new List<int> {31,31,32,32,31,30,30,29,30,29,30,30} },
                {2061, new List<int> {31,32,31,32,31,30,30,30,29,29,30,31} },
                {2062, new List<int> {30,32,31,32,31,31,29,30,29,30,29,31} },
                {2063, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2064, new List<int> {31,31,32,32,31,30,30,29,30,29,30,30} },
                {2065, new List<int> {31,32,31,32,31,30,30,30,29,29,30,31} },
                {2066, new List<int> {31,31,31,32,31,31,29,30,30,29,29,31} },
                {2067, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2068, new List<int> {31,31,32,32,31,30,30,29,30,29,30,30} },
                {2069, new List<int> {31,32,31,32,31,30,30,30,29,29,30,31} },
                {2070, new List<int> {31,31,31,32,31,31,29,30,30,29,30,30} },
                {2071, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2072, new List<int> {31,32,31,32,31,30,30,29,30,29,30,30} },
                {2073, new List<int> {31,32,31,32,31,30,30,30,29,29,30,31} },
                {2074, new List<int> {31,31,31,32,31,31,30,29,30,29,30,30} },
                {2075, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2076, new List<int> {31,32,31,32,31,30,30,30,29,29,30,30} },
                {2077, new List<int> {31,32,31,32,31,30,30,30,29,30,29,31} },
                {2078, new List<int> {31,31,31,32,31,31,30,29,30,29,30,30} },
                {2079, new List<int> {31,31,32,31,31,31,30,29,30,29,30,30} },
                {2080, new List<int> {31,32,31,32,31,30,30,30,29,29,30,30} },
                {2081, new List<int> {31,31,32,32,31,30,30,30,29,30,30,30} },
                {2082, new List<int> {30,32,31,32,31,30,30,30,29,30,30,30} },
                {2083, new List<int> {31,31,32,31,31,30,30,30,29,30,30,30} },
                {2084, new List<int> {31,31,32,31,31,30,30,30,29,30,30,30} },
                {2085, new List<int> {31,32,31,32,30,31,30,30,29,30,30,30} },
                {2086, new List<int> {30,32,31,32,31,30,30,30,29,30,30,30} },
                {2087, new List<int> {31,31,32,31,31,31,30,30,29,30,30,30} },
                {2088, new List<int> {30,31,32,32,30,31,30,30,29,30,30,30} },
                {2089, new List<int> {30,32,31,32,31,30,30,30,29,30,30,30} },
                {2090, new List<int> {30,32,31,32,31,30,30,30,29,30,30,3} }
            };

        public static int GetTotalDaysInMonth(int year, BCMonth month)
        {
            var intValue = (int)month;
            return NepaliCalendarYearDays[year][intValue];
        }
    }
}
