using System;


class CopyRightTriangle
{
    static void Main()
    {
        Console.WriteLine("Do you want to create a triangle?\nPlease enter the row count!");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Now Enter the Symbol that you want to use!");
        char symbol = char.Parse(Console.ReadLine());

        int cells = (rows * 2) - 1;
        int symbolIncrement = 1;
        int blankcount;
        int symbolcount;

        Console.WriteLine("Triangle made of {0}", symbol);
        for (int r = 0; r < rows; r++)
        {
            blankcount = cells - symbolIncrement;
            symbolcount = cells - blankcount;

            string blankCells = new String(' ', blankcount / 2);
            string fullCells = new String(symbol, symbolcount);

            Console.Write("{0}{1}", blankCells, fullCells);

            symbolIncrement = symbolIncrement + 2;
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}