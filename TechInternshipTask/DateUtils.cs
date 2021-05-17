using System;
using System.Collections.Generic;
using System.Text;

namespace TechInternshipTask
{
    static class DateUtils
    {
        public static bool HasSameYearAs(this DateTime date1, DateTime date2)
        {
            return date1.Year == date2.Year;
        }
        public static bool HasSameMonthAs(this DateTime date1, DateTime date2)
        {
            return date1.Month == date2.Month;
        }
        public static bool HasSameDayAs(this DateTime date1, DateTime date2)
        {
            return date1.Day == date2.Day;
        }
    }

}
