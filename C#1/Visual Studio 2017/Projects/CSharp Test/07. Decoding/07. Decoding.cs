using System;

namespace _07.Decoding
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number!");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter a text!");
            string text = Console.ReadLine();
            int b = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (b % 2 == 0)
                {
                    if (i == '@')
                    {
                        break;
                    }
                    else if ('a' <= ch && ch <= 'z')
                    {
                        double a = (ch * num) + 1000;
                        a = a / 100;
                        Console.WriteLine(a);
                    }
                    else if ('A' <= ch && ch <= 'Z')
                    {
                        double a = (ch * num) + 1000;
                        a = a / 100;
                        Console.WriteLine(a);
                    }
                    else if ('0' <= ch && ch <= '9')
                    {
                        double a = ch + num + 500;
                        a = a / 100;
                        Console.WriteLine(a);
                    }
                    else
                    {
                        double a = ch - num;
                        a = a / 100;
                        Console.WriteLine(a);
                    }
                }
                else
                {
                    if (i == '@')
                    {
                        break;
                    }
                    else if ('a' <= ch && ch <= 'z')
                    {
                        double a = (ch * num) + 1000;
                        a = a * 100;
                        Console.WriteLine(a);
                    }
                    else if ('A' <= ch && ch <= 'Z')
                    {
                        double a = (ch * num) + 1000;
                        a = a * 100;
                        Console.WriteLine(a);
                    }
                    else if ('0' <= ch && ch <= '9')
                    {
                        double a = ch + num + 500;
                        a = a * 100;
                        Console.WriteLine(a);
                    }
                    else
                    {
                        double a = ch - num;
                        a = a * 100;
                        Console.WriteLine(a);
                    }
                }
                b++;
            }
        }
    }
}