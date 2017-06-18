using System;

namespace Point__Circle__Rectangle
{
    class Point__Circle__Rectangle
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the coordinates of a point x and y!");
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());
            bool inCircle = (((Math.Pow(x - 1, 2)) + (Math.Pow(y - 1, 2))) <= 1.5 * 1.5);
            bool inRectangle = (x <= 5 && x >= -1) && (y <= 1 && y >= -1);
            if (inCircle && !inRectangle)
            {
                Console.WriteLine("This point is both inside the circe and outside the rectangle!");
            }
            else
            {
                Console.WriteLine("This point isn't both inside the circe and outside the rectangle!");
            }
        }
    }
}
