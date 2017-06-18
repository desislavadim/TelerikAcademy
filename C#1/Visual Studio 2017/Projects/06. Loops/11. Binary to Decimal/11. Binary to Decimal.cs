//Using loops write a program that converts a binary integer number to its decimal form.
using System;

namespace _11.Binary_to_Decimal
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number in binary system!");
            string s = Console.ReadLine();
            Console.Write("The decimal form of \"{0}\" is: ", s);
            
            long num = long.Parse(s);
            double sum = 0;
            for (int i = 0; num > 0; i++)
            {
                long lastDigit = num % 10;
                sum = sum + lastDigit * (Math.Pow(2, i));
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}