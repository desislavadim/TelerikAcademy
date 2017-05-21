using System;

namespace Point_in_a_circle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the coordinates of a point x and y!");
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());
            bool inCircle = (((x * x) + (y * y)) <= 2 * 2);
            Console.WriteLine("This point is in the circle!-{0}", inCircle);
        }
    }
}
