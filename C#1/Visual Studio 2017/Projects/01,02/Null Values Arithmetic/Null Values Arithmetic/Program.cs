using System;

namespace Null_Values_Arithmetic
{
    class Program
    {
        static void Main()
        {
            int? a = null;
            double? b = null;
            Console.WriteLine("{0}\n{1}", a, b);

            a = a + 333;
            b = b + 3.1455;
            Console.WriteLine("{0}\n{1}", a, b);
        }
    }
}
