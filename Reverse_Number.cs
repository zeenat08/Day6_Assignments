using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_LogicalProblems
{
    class Reverse_Number
    {
        public static void CheckReverse()
        {
            Console.Write("Enter a number u want to reverse: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int revNum = 0;
            while(num != 0)
            {
                int digit = num % 10;
                revNum = revNum * 10 + digit;
                num = num / 10;
            }
            Console.WriteLine($"Reverse of the number is: {revNum}");
        }
    }
}
