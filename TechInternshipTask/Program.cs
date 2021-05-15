using System;

namespace TechInternshipTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new DataRageCreator("01.03.2012", "03.04.2015");
            Console.WriteLine(data.GetPrintableData());

        }
    }
}
