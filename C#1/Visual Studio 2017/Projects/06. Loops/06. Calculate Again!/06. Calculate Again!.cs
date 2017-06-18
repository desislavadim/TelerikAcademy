//Write a program that calculates N! / K! for given N and K.
using System;

namespace _06.Calculate_Again_
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
            Console.Write("{0}! / {1}! = ", num1, num2);
            int factorial = 1;
            int factorial1 = 1;
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
            
            Console.WriteLine(factorial / factorial1);
        }
    }
}