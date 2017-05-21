using System;

namespace Circle
{
    class Circle
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the radius of your circle!");
            double r = double.Parse(Console.ReadLine());
            double perimeter = Math.PI * r * 2;
            Console.Write("The perimeter of your circle is: ");
            Console.WriteLine("{0:0.00}", perimeter);
            double area = Math.PI * r * r;
            Console.Write("The area of your circle is: ");
            Console.WriteLine("{0:0.00}", area);
        }
    }
}
