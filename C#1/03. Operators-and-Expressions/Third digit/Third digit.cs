using System;

namespace Third_digit
{
    class Third_digit

    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer number with 3 or more digits!");
            int N = Math.Abs(int.Parse(Console.ReadLine()));
            bool isSeven = (N / 100) % 10 == 7;
            Console.Write("The third digit of {0} is seven!-", N);
            Console.WriteLine(isSeven);
        }
    }
}
