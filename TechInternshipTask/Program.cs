using System;

namespace TechInternshipTask
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var data = new DateRangeCreator(args[0], args[1]);
                Console.WriteLine(data.GetPrintableData());
            }
            catch
            {
            }

        }
    }
}
