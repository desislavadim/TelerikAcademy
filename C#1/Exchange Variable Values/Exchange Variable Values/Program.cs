﻿using System;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c;

            c = a;
            a = b;
            b = c;
            Console.WriteLine("{0},{1}", a, b);
        }
    }
}
