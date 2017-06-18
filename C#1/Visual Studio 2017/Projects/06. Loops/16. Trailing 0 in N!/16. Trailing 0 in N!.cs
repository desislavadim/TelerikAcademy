//Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
using System;
using System.Numerics;

namespace _16.Trailing_0_in_N_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer number!");
            int num = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            BigInteger a;
            int i;
            Console.Write("The factorial of {0} has ", num);
            while (num > 0)
            {
                factorial *= num;
                num--;
            }
            for ( i = -1; a == 0; i++)
            {

                a = factorial % 10;   
                factorial = factorial / 10;
            }
            Console.WriteLine("{0} zeros at the end!", i);
        }
    }
}