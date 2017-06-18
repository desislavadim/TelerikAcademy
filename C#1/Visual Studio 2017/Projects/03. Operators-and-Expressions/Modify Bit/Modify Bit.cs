using System;

namespace Modify_Bit
{
    class Modify_Bit
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the integer number!");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the bit value(v = 0 or 1) you want to use!");
            int bit = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the position you want to use!");
            int position = int.Parse(Console.ReadLine());
            if (bit == 0)
            {
                int a = 1 << position;
                int N = num | a;
                Console.Write("The binary representation of {0} is:", num);
                Console.WriteLine(Convert.ToString(num, 2));
                Console.Write("The new binary representation of {0} is:", num);
                Console.WriteLine(Convert.ToString(N, 2));
            }
            else
            {
                int mask = 1 << position;
                int result1 = num & ~(mask);
                Console.Write("The binary representation of {0} is:", num);
                Console.WriteLine(Convert.ToString(num, 2));
                Console.Write("The new binary representation of {0} is:", num);
                Console.WriteLine(Convert.ToString(result1, 2));
               
            }
        }
    }
}
