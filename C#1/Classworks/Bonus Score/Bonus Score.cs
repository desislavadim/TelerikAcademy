using System;

namespace Bonus_Score
{
    class Bonus_Score
    {
        static void Main()
        {
            Console.WriteLine("Please, enter your score!");
            int a = int.Parse(Console.ReadLine());
            if (a >= 1 && a <= 3)
            {
                Console.WriteLine(a * 10);
            }
            else
            {
                if (a >= 4 && a <= 6)
                {
                    Console.WriteLine(a * 100);
                }
                else
                {
                    if (a >= 7 && a <= 9)
                    {
                        Console.WriteLine(a * 1000);
                    }
                    else
                    {
                        Console.WriteLine("Invalid score!");
                    }
                }
            }
        }
    }
}
