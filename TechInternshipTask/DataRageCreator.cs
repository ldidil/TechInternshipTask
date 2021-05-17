using System;
using System.Globalization;

namespace TechInternshipTask
{
    class DataRageCreator
    {
        private DateTime startingDate;
        private DateTime endDate;

        private CultureInfo cultureInfo;


        public DataRageCreator(string str1, string str2)
        {
            startingDate = ParseMultiCulture(str1);
            endDate = DateTime.Parse(str2, cultureInfo);
            if (startingDate > endDate)
            {
                Swap();
            }
        }

        public DataRageCreator()
        {
        }

        public string GetPrintableData()
        {
            if (!IsYearSame())
            {
                return GetFormatForOtherYear();
            }

            if (!IsMonthSame())
            {
                return GetFormatForOtherMonth();
            }
            if (!IsDaySame())
            {
                return GetFormatForOtherDay();
            }

            return  ( endDate.Day + "." + endDate.Month + "." + endDate.Year);

        }

        private string GetFormatForOtherYear()
        {
            return (startingDate.Day.ToString("00") + "." + 
                startingDate.Month.ToString("00") + "." + 
                startingDate.Year + "-" + 
                endDate.Day.ToString("00") + "." + 
                endDate.Month.ToString("00") + "." + 
                endDate.Year);
        }
        private string GetFormatForOtherMonth()
        {
            return (startingDate.Day.ToString("00") + "." + 
                startingDate.Month.ToString("00") + "-" + 
                endDate.Day.ToString("00") + "." + 
                endDate.Month.ToString("00") + "." + 
                endDate.Year);
        }

        private string GetFormatForOtherDay()
        {
            return (startingDate.Day.ToString("00") + "-" + 
                endDate.Day.ToString("00") + "." + 
                endDate.Month.ToString("00") + "." + 
                endDate.Year);
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


        public DateTime ParseMultiCulture(string dateString)
        {
            DateTime output;

            string[] formatsEu1 = { "dd-MM-yyyy" };
            string[] formatsEu2 = { "dd.MM.yyyy" }; //eu format is the default
            string[] formatsUs1 = { "MM.dd.yyyy" };

            if (DateTime.TryParseExact(dateString, formatsEu1, cultureInfo = new CultureInfo("en-GB"),
                    DateTimeStyles.None, out output))
            {
                return output;
            }

            if (DateTime.TryParseExact(dateString, formatsEu2, cultureInfo = new CultureInfo("de-De"),
                 DateTimeStyles.None, out output))
            {
                return output;
            }


            if (DateTime.TryParseExact(dateString, formatsUs1, cultureInfo= new CultureInfo("en-US"),
                    DateTimeStyles.None, out output))
            {
                return output;
            }

            throw new NotSupportedException("Given datestring is in a format that is not supported.");
        }
    }

}