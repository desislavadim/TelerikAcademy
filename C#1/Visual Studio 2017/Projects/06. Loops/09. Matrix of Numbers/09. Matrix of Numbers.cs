using System;

namespace _09.Matrix_of_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a positive integer number!");
            int num = int.Parse(Console.ReadLine());
            int a = 1;
            int num2 = num * 2;
            while (num < num2)
            {
                for (int i = a; i <= num; i++)
                {
                    Console.Write(i + " ");

                }
                Console.WriteLine();
            
                num++;
                a++;
              
            }


        }
    }
}