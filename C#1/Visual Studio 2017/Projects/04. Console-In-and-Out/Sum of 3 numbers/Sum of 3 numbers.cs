using System;

namespace Sum_of_3_numbers
{
    class Sum_of_3_numbers
    {
        static void Main()
        {
            Console.WriteLine("Please, enter three real numbers!");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.Write("The sum of {0}, {1} and {2} is:", a, b, c);
            Console.WriteLine(a + b + c);
        }
    }
}
