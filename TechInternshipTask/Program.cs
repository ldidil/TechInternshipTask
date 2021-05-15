using System;

namespace TechInternshipTask
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //var string1 = args[0].Split('.', '-');
                //var string2 = args[1].Split('.', '-');


                var string1 = Console.ReadLine().Split('.', '-');
                var string2 = Console.ReadLine().Split('.', '-');



                if (string1[2] != string2[2])
                {
                    Console.WriteLine( string1[0]+"."+string1[1]+"."+ string1[2]+"-" + string2[0] + "." + string2[1] + "." + string2[2]);
                }

                else
                {
                    if (string1[1] != string2[1])
                    {
                        Console.WriteLine(string1[0] + "." + string1[1] + "-" + string2[0] + "." + string2[1] + "." + string2[2]);
                    }
                    else
                    {
                        if (string1[0] != string2[0])
                        {
                            Console.WriteLine(string1[0] +  "-" + string2[0] + "." + string2[1] + "." + string2[2]);
                        }
                        else
                        {
                            Console.WriteLine(string2[0] + "." + string2[1] + "." + string2[2]);
                        }

                    }
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
           
          
        }
    }
}
