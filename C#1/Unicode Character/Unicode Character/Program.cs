using System;

namespace Unicode_Character
{
    class Program
    {
        static void Main()
        {
            char b = char.Parse(Console.ReadLine());
            Console.WriteLine((int)b);
            Console.WriteLine("Hello, {0}!\n", b);


            char a = (char)0X48;
            Console.WriteLine(a);
        }
    }
}
