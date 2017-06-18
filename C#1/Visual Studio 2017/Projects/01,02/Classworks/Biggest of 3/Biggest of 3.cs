using System;

namespace Biggest_of_3
{
    class Biggest_of_3
    {
        static void Main()
        {
            Console.WriteLine("Please, enter three numbers!");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("The biggest number is " + a);
            }
            else
            {
                if (b > a && b > c)
                {
                    Console.WriteLine("The biggest number is " + b);
                }
                else
                {
                    Console.WriteLine("The biggest number is " + c);
                }
            }
        }
    }
}
