using System;
using System.Runtime.CompilerServices;

namespace ConsoleAppExer2
{
    class Program
    {
        public static bool Hello { get; private set; }

        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;

                        case 2:
                            RunExerciseTwo();
                            break;

                        case 3:
                            // call your next assignment method here!
                            break;

                        case -1:
                            keepAlive = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;

                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number!");
                    Console.ResetColor();
                }
            }
        }

        private static void RunExerciseOne()
        {
            String firstname = "Siva";
            String lastname = "Reddy";

            Console.Write("Hello {0} {1}", firstname, lastname);
            Console.WriteLine(" !I’m glad to inform you that you are the test subject of my very first assignment!");
            Console.WriteLine("You successfully ran exercise one!"); ;
        }

        private static void RunExerciseTwo()

        {
            DateTime todaysdate = DateTime.Today;
            Console.WriteLine("Todays date is {0} ",todaysdate.ToString());
            DateTime todaynow = DateTime.Now;
            Console.WriteLine("Todays date is {0} ", todaynow.ToString());
            DateTime tomorosdate = todaysdate.AddDays(1);
            Console.WriteLine("Tomorrow's date is {0}", tomorosdate.ToString());
            DateTime ysterdaysdate = todaysdate.AddDays(-1);
            Console.WriteLine("Yesterday's date is {0}", ysterdaysdate.ToString());
            Console.WriteLine("You successfully ran exercise two!");


            String part = "if you're doing your"; 
            part = part + " best, \tyou won't have any"; 
            String quote = part + " time to worry about failure."; 
            Console.WriteLine(quote);
        }

    }

    
}


