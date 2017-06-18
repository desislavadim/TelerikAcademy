using System;

namespace BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer number!");
            int num = int.Parse(Console.ReadLine());
            int num24 = 1 << 24;
            int num25 = 1 << 25;
            int num26 = 1 << 26;
            int bit24 = (num & num24) >> 24;
            int bit25 = (num & num25) >> 25;
            int bit26 = (num & num26) >> 26;
            int num3 = 1 << 3;
            int num4 = 1 << 4;
            int num5 = 1 << 5;


        }
    }
}
