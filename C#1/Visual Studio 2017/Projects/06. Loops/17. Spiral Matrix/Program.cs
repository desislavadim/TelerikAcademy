//Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) and prints a matrix holding the numbers from 1 to N*N in the form of square spiral like in the examples below.
//4
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7
using System;

namespace _17.Spiral_Matrix
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer number X<20!");
            int num = int.Parse(Console.ReadLine());
            int i;
            for (i = 1; i <= num; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int a = num - 1;
            int b = num + 1;
            int c = i + (num - 2);
            int d = i + 1;
            int e = num * num;
            int p = 2;
            int k = 0;
            
            i = c + a;
            int u =i + (num - 2);


            for (int l = 2; l < num; l++)
            {
                Console.Write(u + " ");
                
                    while (p < num)
                    {
                        p++;
                        u++;
                        Console.Write(u + " ");

                    }
                    int q = u + (num - 2);
                    while (p < num + 1)
                    {
                        p++;
                        u = u - (num - 2);
                    }
               

                u--;
                Console.Write(b);
                b++;
                Console.WriteLine();
            }
            for (p = 0; p < num; p++)
            {
                Console.Write(i + " ");
                i--;
            }
            Console.WriteLine();
        }
    }
}
// NOT COMPLETED