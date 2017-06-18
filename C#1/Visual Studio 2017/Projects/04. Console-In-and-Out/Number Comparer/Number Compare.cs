using System;

namespace Number_Comparer
{
    class Number_Comparer
    {
        static void Main()
        {
            Console.WriteLine("Please, enter two numbers!");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(a > b ? "{0} > {1}" : "{0} < {1}", a, b);
        }
    }
}
