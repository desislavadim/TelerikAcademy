using System;

namespace _06.Three_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter 3 numbers!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int maxNum = Math.Max(a, b);
            maxNum = Math.Max(maxNum, c);
            int minNum = Math.Min(a, b);
            minNum = Math.Min(minNum, c);
            double sum = a + b + c;
            double avr = sum / 3;
            Console.WriteLine("The biggest number is: {0}", maxNum);
            Console.WriteLine("The smallest number is: {0}", minNum);
            Console.WriteLine("The aritmethic mean is: {0:0.00}", avr);
        }
    }
}