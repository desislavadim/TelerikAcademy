using System;

namespace Play_card
{
    class Play_card
    {
        static void Main()
        {
            Console.WriteLine("Is your string a classical cards sign?");
            string a = Console.ReadLine();
            switch (a)
            {
                case "2": Console.WriteLine("Yes " + a);
                    break;
                case "3":
                    Console.WriteLine("Yes " + a);
                    break;
                case "4":
                    Console.WriteLine("Yes " + a);
                    break;
                case "5":
                    Console.WriteLine("Yes " + a);
                    break;
                case "6":
                    Console.WriteLine("Yes " + a);
                    break;
                case "7":
                    Console.WriteLine("Yes " + a);
                    break;
                case "8":
                    Console.WriteLine("Yes " + a);
                    break;
                case "9":
                    Console.WriteLine("Yes " + a);
                    break;
                case "10":
                    Console.WriteLine("Yes " + a);
                    break;
                case "J":
                    Console.WriteLine("Yes " + a);
                    break;
                case "Q":
                    Console.WriteLine("Yes " + a);
                    break;
                case "K":
                    Console.WriteLine("Yes " + a);
                    break;
                case "A":
                    Console.WriteLine("Yes " + a);
                    break;
                default:
                    Console.WriteLine("No " + a);
                    break;
            }
        }
    }
}
