using System;

namespace Moon_Gravity
{
    class Moon_Gravity
    {
        static void Main()
        {
            Console.WriteLine("Please, enter your weight!");
            double a = double.Parse(Console.ReadLine());
            float W = (float)a;
            double b = 17 / (float)100;
            double c = b * W;
            float d = (float)c;
            Console.WriteLine("Your weight on the Moon will be " + "{0}!", d);
        }
    }
}
