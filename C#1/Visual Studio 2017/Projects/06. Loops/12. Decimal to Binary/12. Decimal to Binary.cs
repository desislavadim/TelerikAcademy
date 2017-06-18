//Using loops write a program that converts an integer number to its binary representation.
using System;

namespace _12.Decimal_to_Binary
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number in decimal system!");
            long num = long.Parse(Console.ReadLine());
            Console.Write("The binary representation of \"{0}\" is: ", num);
            long i;
            string str = "";
            for (i = 0; i <= num; i++)
            {
                i = num % 2;
                num = num / 2;
                str = i + str;
                i = 0;
            }
            Console.WriteLine(str);
        }
    }
}