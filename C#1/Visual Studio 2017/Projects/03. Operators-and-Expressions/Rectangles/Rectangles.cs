using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the width and height!");
            Console.Write("Width:");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height:");
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            float floatArea = (float)area;
            double perimeter = (2 * width) + (2 * height);
            float floatPerimeter = (float)perimeter;
            Console.WriteLine("The area:{0} The perimeter:{1}", floatArea, floatPerimeter);
        }
    }
}
