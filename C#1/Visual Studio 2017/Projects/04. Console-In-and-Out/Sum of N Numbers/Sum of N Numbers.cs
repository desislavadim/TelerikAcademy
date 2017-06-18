using System;

namespace Sum_of_N_Numbers
{
    class Sum_of_N_Numbers
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer number!");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter {0} numbers!", n);
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of these numbers is: {0}", sum);
        }
    }
}
