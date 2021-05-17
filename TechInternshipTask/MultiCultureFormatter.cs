using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TechInternshipTask
{
    class MultiCultureFormatter
    {
        DateTime output;
        private CultureInfo cultureInfo;

        string[] formatsEu1 = { "dd-MM-yyyy" };
        string[] formatsEu2 = { "dd.MM.yyyy" };
        string[] formatsUs1 = { "MM.dd.yyyy" };


        public DateTime ParseMultiCulture(string dateString)
        {
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


            if (DateTime.TryParseExact(dateString, formatsUs1, cultureInfo = new CultureInfo("en-US"),
                    DateTimeStyles.None, out output))
            {
                return output;
            }

            throw new NotSupportedException("Given datestring is in a format that is not supported.");
        }
    }
}
