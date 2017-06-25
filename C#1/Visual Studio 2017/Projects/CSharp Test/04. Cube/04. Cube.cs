//Make a cube.
using System;

namespace _04.Cube
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number between 4 and 100!");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("YOUR 3D CUBE:");
            Console.WriteLine();
            int num2 = num;
            string blankCells;
            string fullCells;
            string xCells = new String('X', 1);

            while (num > 0 && xCells.Length < num2 - 2)
            {
                blankCells = new String(' ', num - 1);
                fullCells = new String(':', num - 1);
                if (num == num2)
                {
                    Console.Write(blankCells + ":");
                    Console.WriteLine(fullCells);
                }
                else
                {
                    if (num == num2 - 1)
                    {
                        string slashCells = new String('/', num2 - 2);
                        Console.WriteLine(blankCells + ":" + slashCells + "::");
                    }
                    else
                    {
                        string slashCells = new String('/', num2 - 2);
                        Console.WriteLine(blankCells + ":" + slashCells + ":" + xCells + ":");
                        xCells = xCells + "X";
                    }
                }
                num--;
            }
            fullCells = new String(':', num2);
            blankCells = new String(' ', num2 - 2);
            Console.WriteLine(fullCells + xCells + ":");
            for (int i = 0; i < num2 - 1; i++)
            {
                xCells = xCells.Substring(0, xCells.Length - 1);
                if (xCells.Length > 0)
                {
                    Console.WriteLine(":" + blankCells + ":" + xCells + ":");
                }
                else
                {
                    Console.WriteLine(":" + blankCells + "::");
                    break;
                }
            }
            fullCells = new String(':', num2);
            Console.WriteLine(fullCells);
            Console.WriteLine();
        }
    }
}