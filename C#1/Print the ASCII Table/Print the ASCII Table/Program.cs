using System;

namespace Print_the_ASCII_Table
{
    class Program
    {
        static void Main()
        {
            char a = '~';
            for (char i = '!' ; i < a; i++)
            {
                Console.Write("{0}",i);
            }
        }
    }
}
