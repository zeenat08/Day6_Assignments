using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_LogicalProblems
{
    class Perfect_Number
    {
        public static void IsPerfect()
        {
            int sum = 0;
            Console.Write("Enter a number to check Perfect number or not: ");
            int num = int.Parse(Console.ReadLine());
            for(int i=1; i<num; i++)
            {
                if(num%i==0)
                {
                    sum = sum + i;
                }
            }
            if(num==sum)
            {
                Console.WriteLine($"{num} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{num} is not a perfect number");
            }
        }
    }
}
