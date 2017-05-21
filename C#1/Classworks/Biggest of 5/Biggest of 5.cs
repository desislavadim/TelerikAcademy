using System;

namespace Biggest_of_5
{
    class Biggest_of_5
    {
        static void Main()
        {
            Console.WriteLine("Please, enter five numbers!");
            double one = double.Parse(Console.ReadLine());
            double two = double.Parse(Console.ReadLine());
            double three = double.Parse(Console.ReadLine());
            double four = double.Parse(Console.ReadLine());
            double five = double.Parse(Console.ReadLine());
            if (one > two && one > three && one > four && one > five)
                Console.WriteLine("The biggest number is " + one);
            if (two > one && two > three && two > four && two > five)
                Console.WriteLine("The biggest number is " + two);
            if (three > one && three > two && three > four && three > five)
                Console.WriteLine("The biggest number is " + three);
            if (four > one && four > two && four > three && four > five)
            {
                Console.WriteLine("The biggest number is " + four);
            }
            else
            {
                Console.WriteLine("The biggest number is " + five);
            }
        }
    }
}
