using System;
using System.Numerics;

namespace _08.ConsoleAplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter your numbers!");
            int b = 0;
            BigInteger product = 1;
            string str = Console.ReadLine();
            do
            {
                int a = Convert.ToInt32(str);
                if (b % 2 != 0)
                {
                    while (a != 0)
                    {

                        int c = a % 10;
                        if (c == 0)
                        {
                            a = a / 10;
                            continue;
                        }
                        product *= c;

                        a = a / 10;

                    }

                }
                b++;
                str = Console.ReadLine();
            }
            while (str != "END" && b < 10);
            Console.WriteLine(product);
            product = 1;
            if (b >= 10)
            {
                do
                {
                    int a = Convert.ToInt32(str);
                    if (b % 2 != 0)
                    {
                        while (a != 0)
                        {

                            int c = a % 10;
                            if (c == 0)
                            {
                                a = a / 10;
                                continue;
                            }
                            product *= c;

                            a = a / 10;

                        }

                    }
                    b++;
                    str = Console.ReadLine();
                }
                while (str != "END");
                Console.WriteLine(product);
            }
        }
    }
}