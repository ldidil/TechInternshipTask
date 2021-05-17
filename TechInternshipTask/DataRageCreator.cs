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
            var formatter = new MultiCultureFormatter();
            startingDate = formatter.ParseMultiCulture(str1);
            endDate = formatter.ParseMultiCulture(str2);
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


       
    }

}