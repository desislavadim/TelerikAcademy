using System;

namespace Sum_of_5_numbers
{
    class Sum_of_5_numbers
    {
        static void Main()
        {
            Console.WriteLine("Please, enter 5 numbers!");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double sum = a + b + c + d + e;
            Console.WriteLine("The sum of this numbers is: {0}", sum);
        }
    }
}
