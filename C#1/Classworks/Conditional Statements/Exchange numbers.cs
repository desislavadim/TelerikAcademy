using System;

namespace Exchange_numbers
{
    class Exchange_numbers
    {
        static void Main()
        {
            Console.WriteLine("Please, enter two numbers!");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            var c = a;
            var d = b;
            if (c > d)
            {
                a = d;
                b = c;
                Console.WriteLine(a + " " + b);
            }
            else
            {
                Console.WriteLine(c + " " + d);
            }

        }
    }
}
