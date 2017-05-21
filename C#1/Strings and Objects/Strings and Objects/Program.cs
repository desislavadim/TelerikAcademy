using System;

namespace Strings_and_Objects
{
    class Program
    {
        static void Main()
        {
            string a = "Hello";
            string b = "World";
            object obj = a + " " + b;
            string c = (string)obj;
            Console.WriteLine(c);
        }
    }
}
