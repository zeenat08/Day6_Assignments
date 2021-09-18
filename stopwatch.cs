using System;
using System.Threading;
using System.Diagnostics;

namespace LogicalPrograms
{
	class Stopwatch
	{
		public static void TimeElapsed()
		{
			System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
			timer.Start();
			for (int i = 0; i < 100; i++)
			{
				Thread.Sleep(2);
			}
			timer.Stop();
			Console.WriteLine(" Time elapsed: {0} ", timer.Elapsed);
		}
	}

}
