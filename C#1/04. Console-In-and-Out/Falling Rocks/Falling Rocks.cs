using System;
using System.Diagnostics;
using System.Text;

namespace Falling_Rocks
{
    class Falling_Rocks
    {
        static void Main()
        {
            // constants
            const char wallSymbol = '█';
            const char player = '☻';
            const char coffee = '©';
            const int escapeX = 14;
            const int escapeY = 1;
            const int consoleWidth = 16;
            const int consoleHight = 7;

            // console prep

            Console.WindowHeight = consoleHight;
            Console.WindowWidth = consoleWidth;
            Console.BufferWidth = consoleWidth;
            Console.BufferHeight = consoleHight;
            Console.CursorVisible = false;

            // setup the date
            string[] maze = new string[] 
            {
                "███████████████",
                "█©   █         ",
                "█   █████████ █",
                "█     █       █",
                "█  ████████ ███",
                "█             █",
                "███████████████"
            };


            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(1 ,6);
            Console.WriteLine('☻');

            int playerX = 1;
            int playerY = 5;
            int coffeeColected = 0;


            Stopwatch timer = new Stopwatch();
            timer.Start();
            while ((playerX != escapeX) || (playerY != escapeY))
            {
                // print the maze
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(string.Join(Environment.NewLine, maze));

                // print the player
                Console.SetCursorPosition(playerX, playerY);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(player);

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch(keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (maze[playerY - 1][playerX] != wallSymbol)
                        {
                            playerY--;
                        }
                        
                        break;
                        case ConsoleKey.DownArrow:
                        if (maze[playerY + 1][playerX] != wallSymbol)
                        {
                            playerY++;
                        }
                        break;
                        case ConsoleKey.RightArrow:
                        if (maze[playerY][playerX + 1] != wallSymbol)
                        {
                            playerX++;
                        }
                        break;
                        case ConsoleKey.LeftArrow:

                        if (maze[playerY][playerX - 1] != wallSymbol)
                        {
                            playerX--;
                        }
                        break;
                    default:
                        break;
                }
                if (playerX == 1 && playerY == 1)
                {
                   
                }
            }

            timer.Stop();
            string message = timer.Elapsed.Seconds <= 15 ? "YOU WIN" : "YOU LOST";
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(message);
            Console.WriteLine("You got out in {0} seconds", timer.Elapsed.Seconds);
        }
    }
}
