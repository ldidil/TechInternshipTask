using System;

namespace TechInternshipTask
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //var data = new DataRageCreator(args[0], args[1]);
                var data = new DataRageCreator("23.02.1998", "03.22.1998");
                Console.WriteLine(data.GetPrintableData());
            }
            catch
            {

                Console.WriteLine("ERROR - wrong input data ");
                System.Environment.Exit(0);
            }

        }
    }
}
