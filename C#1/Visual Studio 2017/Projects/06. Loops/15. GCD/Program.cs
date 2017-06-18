//Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.
using System;

namespace GCD
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter two integer numbers!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.Write("The greatest common divisor of {0} and {1} is: ", a, b);

            if (b == 0)
            {
                Console.WriteLine(a);
            }
            else
            {
                int f = a % b;
                Console.WriteLine(f);
            }
        }
    }
}