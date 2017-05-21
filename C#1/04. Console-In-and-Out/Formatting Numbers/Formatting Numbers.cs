using System;

namespace Formatting_Numbers
{
    class Formatting_Numbers
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer number bigger than 0 and smaller than 500 and two floating-point nubers!");
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            string hexA = a.ToString("X");
            String decA = Convert.ToString(a, 2).PadLeft(10, '0');
            Console.WriteLine("{0, -10} {1, -10} {2:0.00} {3:0.00}", hexA, decA, b, c);
        }
    }
}
