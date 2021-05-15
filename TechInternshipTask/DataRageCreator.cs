using System;

namespace TechInternshipTask
{
    class DataRageCreator
    {
        string[] string1 = new string[3];
        string[] string2 = new string[3];


        public DataRageCreator(string str1, string str2)
        {

            if (str1.Split('.', '-').Length == 3 && str2.Split('.', '-').Length == 3)
            {
                string1 = str1.Split('.', '-');
                string2 = str2.Split('.', '-');
            }
            else
            {
                Console.WriteLine("ERROR - wrong input data ");
                System.Environment.Exit(0);
            }

        }

        public string GetPrintableData()
        {
            if (string1[2] != string2[2])
            {
                if (Int32.Parse(string1[2]) > Int32.Parse(string2[2])) Swap();
                return (string1[0] + "." + string1[1] + "." + string1[2] + "-" + string2[0] + "." + string2[1] + "." + string2[2]);
            }

            else
            {
                if (string1[1] != string2[1])
                {
                    if (Int32.Parse(string1[1]) > Int32.Parse(string2[1])) Swap();
                    return (string1[0] + "." + string1[1] + "-" + string2[0] + "." + string2[1] + "." + string2[2]);
                }
                else
                {
                    if (string1[0] != string2[0])
                    {
                        if (Int32.Parse(string1[0]) > Int32.Parse(string2[0])) Swap();
                        return string1[0] + "-" + string2[0] + "." + string2[1] + "." + string2[2];
                    }
                    else
                    {
                        return string2[0] + "." + string2[1] + "." + string2[2];
                    }
                }
            }
        }

        private void Swap()
        {
            var tempStr = string1;
            string1 = string2;
            string2 = tempStr;

        }
    }
}