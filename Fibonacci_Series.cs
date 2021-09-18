using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_LogicalProblems
{
    class Fibonacci_Series
    {
        public static void CalculateFibonacci()
        {
            int num1 = 0, num2 = 1;
            Console.Write("Enter the number of elements to print: ");
            int numberOfElements = int.Parse(Console.ReadLine());
            Console.Write(num1 + " " + num2 + " ");
            for(int i=2; i<=numberOfElements; i++)
            {
                int nextNumber = num1 + num2;
                Console.Write(nextNumber+ " ");
                num1 = num2;
                num2 = nextNumber;
            }
        }
    }
}
