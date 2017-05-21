using System;

namespace Prime_check
{
    class Prime_check
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer number smaller or equal to 100!");
            int N = Math.Abs(int.Parse(Console.ReadLine()));
            bool yes = true;
            bool no = false;
            if ((N % 2 == 0 && N % 3 == 0) || (N % 2 == 0 && N % 5 == 0) || (N % 2 == 0 && N % 7 == 0) || (N % 3 == 0 && N % 5 == 0) || (N % 3 == 0 && N % 7 == 0) || (N % 5 == 0 && N % 7 == 0) || (N % 4 == 0) || (N % 9 == 0) || (N % 25 == 0) || (N % 49 == 0))
            {
                Console.WriteLine("This number is prime! - {0}", no);
            }
            else
            {
                Console.WriteLine("This number is prime! - {0}", yes);
            }
        }
    }
}
