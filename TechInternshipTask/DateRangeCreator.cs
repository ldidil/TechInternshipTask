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
            if (startingDate.Year != endDate.Year)
            {
                return GetFormatFullDates();
            }

            if (startingDate.Month != endDate.Month)
            {
                return GetFormatSameYear();
            }
            if (startingDate.Day != endDate.Day)
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