using System;

namespace _3rd_Bit
{
    class _3rd_Bit
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer number!");
            uint a = uint.Parse(Console.ReadLine());
            uint mask = 1 << 3;
            uint result1 = a & mask;
            uint result = result1 >> 3;
            Console.Write("The third bit is: ");
            Console.WriteLine(Convert.ToString(result, 2));
        }
    }
}
