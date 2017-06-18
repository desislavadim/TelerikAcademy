using System;

namespace Quadratic_Equation
{
    class Quadratic_Equation
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the coefficients a, b and c!");
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());
            double d = (b * b) - (4 * a * c);
            double squareD = Math.Sqrt(d);
            double x1 = (-b - squareD) / (2 * a);
            double x2 = (-b + squareD) / (2 * a);
            if (d < 0)
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                if (x1 == x2)
                {
                    Console.WriteLine("x = {0:0.00}", x1);
                }
                else
                {
                    if (x1 < x2)
                    {
                        Console.WriteLine("x1 = {0:0.00}", x1);
                        Console.WriteLine("x2 = {0:0.00}", x2);
                    }
                    else
                    {
                        Console.WriteLine("x2 = {0:0.00}", x2);
                        Console.WriteLine("x1 = {0:0.00}", x1);
                    }
                }
            }
        }
    }
}
