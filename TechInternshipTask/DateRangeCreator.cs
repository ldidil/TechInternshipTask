using System;

namespace TechInternshipTask
{
    class DateRangeCreator
    {
        private DateTime startingDate;
        private DateTime endDate;


        public DateRangeCreator(string str1, string str2)
        {
            var formatter = new DateParser();
            startingDate = formatter.Parse(str1);
            endDate = formatter.Parse(str2);
            if (startingDate > endDate)
            {
                Swap();
            }
        }

        public DateRangeCreator()
        {
        }

        public string GetPrintableData()
        {
            if (!startingDate.HasSameYearAs(endDate))
            {
                return GetFormatFullDates();
            }

            if (!startingDate.HasSameMonthAs(endDate))
            {
                return GetFormatSameYear();
            }
            if (!startingDate.HasSameDayAs(endDate))
            {
                return GetFormatSameMonthAndYear();
            }

            return (endDate.Day + "." + endDate.Month + "." + endDate.Year);

        }

        private string GetFormatFullDates
()
        {
            return (startingDate.Day.ToString("00") + "." +
                startingDate.Month.ToString("00") + "." +
                startingDate.Year + "-" +
                endDate.Day.ToString("00") + "." +
                endDate.Month.ToString("00") + "." +
                endDate.Year);
        }
        private string GetFormatSameYear()
        {
            return (startingDate.Day.ToString("00") + "." +
                startingDate.Month.ToString("00") + "-" +
                endDate.Day.ToString("00") + "." +
                endDate.Month.ToString("00") + "." +
                endDate.Year);
        }

        private string GetFormatSameMonthAndYear()
        {
            return (startingDate.Day.ToString("00") + "-" +
                endDate.Day.ToString("00") + "." +
                endDate.Month.ToString("00") + "." +
                endDate.Year);
        }

        private void Swap()
        {
            var temp = startingDate;
            startingDate = endDate;
            endDate = temp;

        }
    }

}