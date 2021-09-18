using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Day6_LogicalProblems
{
    class StopWatch
    {
		public static void TimeElapsed()
		{
            Console.WriteLine("Stowatch is running....");
            // Create new stopwatch.
            Stopwatch timer = new Stopwatch();

            // Begin timing.
            timer.Start();

            // Do something.
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }
            timer.Stop();
			Console.WriteLine(" Time elapsed: {0} ", timer.Elapsed);
		}
	}
}
