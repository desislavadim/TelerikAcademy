//You are given N integers (given in a single line, separated by a space).

//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
using System;

namespace _10.Odd_and_Even_Product
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer number[4; 50]!");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter {0} nubers!", num);
            int evenproduct = 1;
            int oddproduct = 1;

            for (int i = 0; i < num; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    evenproduct *= a;
                }
                else
                {
                    oddproduct *= a;
                }
            }
            Console.WriteLine("Even product = " + evenproduct);
            Console.WriteLine("Odd product = " + oddproduct);
            if (evenproduct == oddproduct)
            {
                Console.WriteLine(evenproduct + "=" + oddproduct);
            }
            else
            {
                Console.WriteLine(evenproduct + " is not equal to " + oddproduct);
            }
        }
    }
}