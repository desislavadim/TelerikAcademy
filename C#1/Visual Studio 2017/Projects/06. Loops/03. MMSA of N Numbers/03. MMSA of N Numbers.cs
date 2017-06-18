//Write a program that reads from the console a sequence of N integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
using System;

using System.Collections.Generic;

namespace _03.MMSA_of_N_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please. enter an integer number!");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter {0} numbers!", num);
            double sum = 0;
            double avr = 0;
            double min = 0;
            double max = 0;
            int a = 0;
            int a1 = a;
            a = int.Parse(Console.ReadLine());
            max = Math.Max(a, a1);
            min = Math.Min(a, a1);
            sum += a;
             a1 = a;
            a = int.Parse(Console.ReadLine());
            max = Math.Max(a, a1);
            min = Math.Min(a, a1);
            sum += a;
            for (int i = 2; i < num; i++)
            {
                a = int.Parse(Console.ReadLine());
                max = Math.Max(a, max);
                min = Math.Min(a, min);
                sum += a;
            }
            avr = sum / num;
            Console.WriteLine("min = {0:0.00}", min);
            Console.WriteLine("max = {0:0.00}", max);
            Console.WriteLine("sum = {0:0.00}", sum);
            Console.WriteLine("avg = {0:0.00}", avr);

        }
    }
}