﻿using System;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the sides a and b and the height h of your trapezoid!");
            Console.Write("a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h:");
            double h = double.Parse(Console.ReadLine());
            double area = ((a + b) * h) / 2;
            Console.WriteLine("The area of the trapezoid is: {0}", area);
        }
    }
}
