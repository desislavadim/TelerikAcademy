using System;

namespace N_th_Bit
{
    class N_th_Bit
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer number!");
            int P = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the bit you want to check!");
            int N = int.Parse(Console.ReadLine());
            int mask = 1 << N;
            int result1 = P & mask;
            int result = result1 >> N;
            Console.Write("Your bit is: ");
            Console.WriteLine(Convert.ToString(result, 2));

        }
    }
}
