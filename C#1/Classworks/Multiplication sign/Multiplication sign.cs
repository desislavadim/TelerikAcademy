﻿using System;

namespace Multiplication_sign
{
    class Multiplication_sign
    {
        static void Main()
        {
            Console.WriteLine("Please, enter three real numbers!");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                if ((a < 0 || b < 0 || c < 0) && (a != 0 && b != 0 && c != 0))
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
