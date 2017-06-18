using System;

namespace Numbers_from_1_to_N
{
    class Numbers_from_1_to_N
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer number!");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
