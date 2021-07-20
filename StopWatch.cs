using System;
using System.Diagnostics;
using System.Threading;

namespace StopWatch
{
    public class StopWatch
    {
        static void Main()
        {
            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();
            // Begin timing
            String choice ="y";
            stopwatch.Start();
            while(choice=="y"||choice == "Y")
            {
                    Console.WriteLine("for loop watch press(y)\notherwise stop the watch(n)");
                    choice = Console.ReadLine();
                    if (choice == "y" || choice == "Y") {
                        stopwatch.Stop();
                        Console.WriteLine("Time Elapsed : {0}", stopwatch.Elapsed);
                        stopwatch.Start();
                    }
                    else if(choice == "n" || choice == "N")
                    {
                        break;
                    }
                    else {
                        Console.WriteLine("invalid choice");
                    }                   

            }
            // Stop timing
            stopwatch.Stop();
            Console.WriteLine("stopwatch stoped : {0}", stopwatch.Elapsed);
        }
    }
}
