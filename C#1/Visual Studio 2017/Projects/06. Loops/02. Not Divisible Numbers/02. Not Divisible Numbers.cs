﻿//Write a program that reads from the console a positive integer N and prints all the numbers from 1 to N not divisible by 3 or 7, on a single line, separated by a space.


using System;

namespace _02.Not_Divisible_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer number!");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}