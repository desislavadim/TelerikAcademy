//Your task is to write a program that calculates N! / (K! * (N - K)!) for given N and K.

using System;
using System.Numerics;

namespace _07.Calculate_3_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a integer number!");
            Console.Write("num1 = ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter a smaller number than {0}!", num1);
            Console.Write("num2 = ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("{0}! / ({1}! * ({0} - {1})!) = ", num1, num2);
            BigInteger factorial = 1;
            BigInteger factorial1 = 1;
            BigInteger factorial2 = 1;
            int a = num1 - num2;

            do
            {
                factorial *= num1;
                num1--;
                if (num2 < 1)
                {
                    continue;
                }
                factorial1 *= num2;
                num2--;


            }
            while (num1 >= 1 || num2 >= 1);
            
            do
            {
                factorial2 *= a;
                a--;
            }
            while (a > 0);
            
            Console.WriteLine(factorial / (factorial1 * factorial2));
            
        }
    }
}