using System;
using System.Globalization;

namespace TechInternshipTask
{
    class DateParser : IDateParser
    {
        private CultureInfo cultureInfo;

        string[] formatsEu1 = { "dd-MM-yyyy" };
        string[] formatsEu2 = { "dd.MM.yyyy" };
        string[] formatsUs = { "MM.dd.yyyy" };
        string[] formatsAsia = { "yyyy.mm.dd" };


        public DateTime Parse(string dateString)
        {
            DateTime output;

            if (cultureInfo != null)
            {
                return DateTime.Parse(dateString, cultureInfo);
            }

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

            if (DateTime.TryParseExact(dateString, formatsUs, cultureInfo = new CultureInfo("en-US"),
                    DateTimeStyles.None, out output))
            {
                return output;
            }


            throw new NotSupportedException("Given datestring is in a format that is not supported.");
        }
    }
}
