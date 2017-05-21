using System;
using System.Collections.Generic;

namespace Print_a_Deck
{
    class Print_a_Deck
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a card sign!");
            string cardSign = (Console.ReadLine());
            string[] list = {"2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds", "3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds", "4 of spades, 4 of clubs, 4 of hearts, 4 of diamonds", "5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds", "6 of spades, 6 of clubs, 6 of hearts, 6 of diamonds", "7 of spades, 7 of clubs, 7 of hearts, 7 of diamonds", "8 of spades, 8 of clubs, 8 of hearts, 8 of diamonds", "9 of spades, 9 of clubs, 9 of hearts, 9 of diamonds", "10 of spades, 10 of clubs, 10 of hearts, 10 of diamonds", "J of spades, J of clubs, J of hearts, J of diamonds", "Q of spades, Q of clubs, Q of hearts, Q of diamonds", "K of spades, K of clubs, K of hearts, K of diamonds", "A of spades, A of clubs, A of hearts, A of diamonds"};
            switch (cardSign)
            {
                case "2":
                    Console.WriteLine(list[0]);
                    Console.WriteLine(list[1]);
                    Console.WriteLine(list[2]);
                    Console.WriteLine(list[3]);
                    Console.WriteLine(list[4]);
                    Console.WriteLine(list[5]);
                    Console.WriteLine(list[6]);
                    Console.WriteLine(list[7]);
                    Console.WriteLine(list[8]);
                    Console.WriteLine(list[9]);
                    Console.WriteLine(list[10]);
                    Console.WriteLine(list[11]);
                    Console.WriteLine(list[12]);
                    break;
                case "3":
                    Console.WriteLine(list[1]);
                    Console.WriteLine(list[2]);
                    Console.WriteLine(list[3]);
                    Console.WriteLine(list[4]);
                    Console.WriteLine(list[5]);
                    Console.WriteLine(list[6]);
                    Console.WriteLine(list[7]);
                    Console.WriteLine(list[8]);
                    Console.WriteLine(list[9]);
                    Console.WriteLine(list[10]);
                    Console.WriteLine(list[11]);
                    Console.WriteLine(list[12]);
                    break;
                case "4":
                    Console.WriteLine(list[2]);
                    Console.WriteLine(list[3]);
                    Console.WriteLine(list[4]);
                    Console.WriteLine(list[5]);
                    Console.WriteLine(list[6]);
                    Console.WriteLine(list[7]);
                    Console.WriteLine(list[8]);
                    Console.WriteLine(list[9]);
                    Console.WriteLine(list[10]);
                    Console.WriteLine(list[11]);
                    Console.WriteLine(list[12]);
                    break;
                case "5":
                    Console.WriteLine(list[3]);
                    Console.WriteLine(list[4]);
                    Console.WriteLine(list[5]);
                    Console.WriteLine(list[6]);
                    Console.WriteLine(list[7]);
                    Console.WriteLine(list[8]);
                    Console.WriteLine(list[9]);
                    Console.WriteLine(list[10]);
                    Console.WriteLine(list[11]);
                    Console.WriteLine(list[12]);
                    break;
                case "6":
                    Console.WriteLine(list[4]);
                    Console.WriteLine(list[5]);
                    Console.WriteLine(list[6]);
                    Console.WriteLine(list[7]);
                    Console.WriteLine(list[8]);
                    Console.WriteLine(list[9]);
                    Console.WriteLine(list[10]);
                    Console.WriteLine(list[11]);
                    Console.WriteLine(list[12]);
                    break;
                case "7":
                    Console.WriteLine(list[5]);
                    Console.WriteLine(list[6]);
                    Console.WriteLine(list[7]);
                    Console.WriteLine(list[8]);
                    Console.WriteLine(list[9]);
                    Console.WriteLine(list[10]);
                    Console.WriteLine(list[11]);
                    Console.WriteLine(list[12]);
                    break;
                case "8":
                    Console.WriteLine(list[6]);
                    Console.WriteLine(list[7]);
                    Console.WriteLine(list[8]);
                    Console.WriteLine(list[9]);
                    Console.WriteLine(list[10]);
                    Console.WriteLine(list[11]);
                    Console.WriteLine(list[12]);
                    break;
                case "9":
                    Console.WriteLine(list[7]);
                    Console.WriteLine(list[8]);
                    Console.WriteLine(list[9]);
                    Console.WriteLine(list[10]);
                    Console.WriteLine(list[11]);
                    Console.WriteLine(list[12]);
                    break;
                    Console.WriteLine(list[8]);
                    Console.WriteLine(list[9]);
                    Console.WriteLine(list[10]);
                    Console.WriteLine(list[11]);
                    Console.WriteLine(list[12]);
                    break;
                case "J":
                    Console.WriteLine(list[9]);
                    Console.WriteLine(list[10]);
                    Console.WriteLine(list[11]);
                    Console.WriteLine(list[12]);
                    break;
                case "Q":
                    Console.WriteLine(list[10]);
                    Console.WriteLine(list[11]);
                    Console.WriteLine(list[12]);
                    break;
                case "K":
                    Console.WriteLine(list[11]);
                    Console.WriteLine(list[12]);
                    break;
                case "A":
                    Console.WriteLine(list[12]);
                    break;
                default:
                    Console.WriteLine("Wrong sign!");
                    break;
            }
        }
    }
}
