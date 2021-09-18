using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_LogicalProblems
{
    class Prime_Number
    {
        public static void IsPrime()
        {
            int num;
            Console.Write("Enter a number to check Prime or not: ");
            num = int.Parse(Console.ReadLine());
            for(int i=2; i<=num/2; i++)
            {
                if(num%i == 0)
                {
                    Console.WriteLine( num + " is not a Prime Number");
                    return;
                } 
            }
            Console.WriteLine(num + " is a Prime Number");
        }
    }
}
