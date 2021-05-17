using System;
using System.Globalization;

namespace TechInternshipTask
{
    class DataRageCreator
    {
        private DateTime startingDate;
        private DateTime endDate;


        public DataRageCreator(string str1, string str2)
        {
            startingDate = ParseMultiCulture(str1);
            endDate = ParseMultiCulture(str2);
            if (startingDate > endDate)
            {
                Swap();
            }
        }

        public string GetPrintableData()
        {
            if (IsYearSame())
            {
                return GetFormatForOtherYear();
            }

            if (IsMonthSame())
            {
                return GetFormatForOtherMonth();
            }
            if (IsDaySame())
            {
                return GetFormatForOtherDay();
            }

            return  ( endDate.Day + "." + endDate.Month + "." + endDate.Year);

        }

        private string GetFormatForOtherYear()
        {
            return (startingDate.Day + "." + startingDate.Month + "." + startingDate.Year + "-" + endDate.Day + "." + endDate.Month + "." + endDate.Year);
        }
        private string GetFormatForOtherMonth()
        {
            return (startingDate.Day + "." + startingDate.Month + "-" + endDate.Day + "." + endDate.Month + "." + endDate.Year);
        }

        private string GetFormatForOtherDay()
        {
            return (startingDate.Day + "-" + endDate.Day + "." + endDate.Month + "." + endDate.Year);
        }

        private bool IsYearSame()
        {
            return startingDate.Year == endDate.Year;
        }

        private bool IsMonthSame()
        {
            return startingDate.Month == endDate.Month;
        }

        private bool IsDaySame()
        {
            return startingDate.Day == endDate.Day;
        }


        private void Swap()
        {
            var temp = startingDate;
            startingDate = endDate;
            endDate = temp;

        }


        private DateTime ParseMultiCulture(string dateString)
        {
            DateTime output;

            string[] formatsUs1 = { "MM.dd.yyyy" };
            string[] formatsEu1 = { "dd-MM-yyyy" };
            string[] formatsEu2 = { "dd.MM.yyyy" };


            if (DateTime.TryParseExact(dateString, formatsUs1, new CultureInfo("en-US"),
                    DateTimeStyles.None, out output))
            {
                return output;
            }

            if (DateTime.TryParseExact(dateString, formatsEu1, new CultureInfo("en-GB"),
                    DateTimeStyles.None, out output))
            {
                return output;
            }

            if (DateTime.TryParseExact(dateString, formatsEu2, new CultureInfo("de-De"),
                 DateTimeStyles.None, out output))
            {
                return output;
            }


            throw new NotSupportedException("Given datestring is in a format that is not supported.");
        }
    }

}