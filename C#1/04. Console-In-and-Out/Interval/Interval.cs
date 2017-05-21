using System;

namespace Interval
{
    class Interval
    {
        static void Main()
        {
            Console.WriteLine("Please, enter two integer numbers!");
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int m = Math.Abs(int.Parse(Console.ReadLine()));
            if (n > m)
            {
                int a = n - m;
                int b = a / 5;
                Console.WriteLine(b);
            }
            else
            {
                int a = m - n;
                int b = a / 5;
                Console.WriteLine(b);   
            }
        }
    }
}
