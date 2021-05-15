using System;
using System.Collections.Generic;
using System.Text;

namespace TechInternshipTask
{
    class DataRageCreator
    {
        string[] string1 = new string[3];
        string[] string2 = new string[3];


        public DataRageCreator(string str1, string str2)
        {
            string1 = str1.Split('.', '-');
            string2 = str2.Split('.', '-');
        }

        public string GetPrintableData()
        {
            if (string1[2] != string2[2])
            {
                return (string1[0] + "." + string1[1] + "." + string1[2] + "-" + string2[0] + "." + string2[1] + "." + string2[2]);
            }

            else
            {
                if (string1[1] != string2[1])
                {
                    return (string1[0] + "." + string1[1] + "-" + string2[0] + "." + string2[1] + "." + string2[2]);
                }
                else
                {
                    if (string1[0] != string2[0])
                    {
                        return string1[0] + "-" + string2[0] + "." + string2[1] + "." + string2[2];
                    }
                    else
                    {
                        return string2[0] + "." + string2[1] + "." + string2[2];
                    }
                }
            }
        }

    }
}