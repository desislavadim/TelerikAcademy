using System;

namespace Divide_by_7_and_5
{
    class Divide_by_7_and_5
    {
        static void Main()
        {
            Console.WriteLine("Please, enter an integer number!");
            int a = int.Parse(Console.ReadLine());
            if (((a % 5) == 0) && ((a % 7) == 0))
            {
                Console.WriteLine("true {0}" + " - This number can be devided by 7 and 5 simultaneously.", a);
            }
            else
            {
                Console.WriteLine("false {0}" + " - This number can't be devided by 7 and 5 simultaneously.", a);
            }
        }
    }
}
