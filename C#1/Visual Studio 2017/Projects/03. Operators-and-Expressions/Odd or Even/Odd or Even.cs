using System;

namespace _03.Operators_and_Expressions
{
    class Odd_or_Even
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer number!");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("The number {0} is even!", a);
            }
            else
            {
                Console.WriteLine("The number {0} is odd!", a);
            }
        }
    }
}