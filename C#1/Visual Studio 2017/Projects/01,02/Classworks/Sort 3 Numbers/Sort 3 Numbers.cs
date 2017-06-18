using System;

namespace Sort_3_Numbers
{
    class Sort_3_Numbers
    {
        static void Main()
        {
            Console.WriteLine("Please, enter three numbers!");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if ((a > b && b > c) || (a == b && a > c) || (b == c && b < a))
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else
            {
                if ((a > c && c > b) || (a == c && a > b))
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b );
                }
                else
                {
                    if ((b > a && a > c) || (a == c && a < b))
                    {
                        Console.WriteLine("{0} {1} {2}", b, a, c);
                    }
                    else
                    {
                        if ((b > c && c > a) || (b == c && b > a))
                        {
                            Console.WriteLine("{0} {1} {2}", b, c, a);
                        }
                        else
                        {
                            if ((c > a && a > b) || (a == b && a < c))
                            {
                                Console.WriteLine("{0} {1} {2}", c, a, b);
                            }
                            else
                            {
                                Console.WriteLine("{0} {1} {2}", c, b, a);
                            }
                        }
                    }
                }
            }
        }
    }
}
