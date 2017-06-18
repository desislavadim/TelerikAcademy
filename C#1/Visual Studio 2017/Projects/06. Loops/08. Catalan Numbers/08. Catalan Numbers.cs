//Write a program to calculate the Nth Catalan number by given N
using System;

using System.Numerics;

namespace _08.Catalan_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer number!");
            int num = int.Parse(Console.ReadLine());
            int product = 2 * num;
            int sum = num + 1;
            BigInteger factorial = 1;
            BigInteger factorial1 = 1;
            BigInteger factorial2 = 1;

            Console.Write("The {0} number of the Catalan sequance is: ", num);

            //C = (2N)! / ((N + 1)! * N!)
            do
            {
                
                factorial *= product;
                product--;
                if (sum < 1)
                {
                    continue;
                }
                factorial1 *= sum;
                sum--;
                if (num < 1)
                {
                    continue;
                }
                factorial2 *= num;
                num--;
            }
            while (product > 0 || sum > 0 || num > 0);

            BigInteger a = factorial / (factorial1 * factorial2);

            if (a == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}