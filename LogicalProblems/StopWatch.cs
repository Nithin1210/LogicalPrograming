using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class StopWatch
    {
        public static void Timer()
        {
            Console.WriteLine("Stopwatch Program \n Press any key to start the stopwatch !!");
            Console.ReadKey();

            DateTime startTime = DateTime.Now;

            Console.WriteLine("Stopwatch started. \nPress any key to stop the stopwatch !! ");
            Console.ReadKey();

            DateTime endTime = DateTime.Now;

            TimeSpan elapsedTime = endTime - startTime;

            Console.WriteLine("Stopwatch stopped.");
            Console.WriteLine("Elapsed time: " + elapsedTime);
        }
    }
}
