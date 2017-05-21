using System;

namespace Int__Double__String
{
    class Int__Double__String
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the type of your variable!");
            Console.WriteLine("integer for int");
            Console.WriteLine("real for double");
            Console.WriteLine("text for string");
            switch (Console.ReadLine())
            {
                case "integer":
                    Console.WriteLine("Please, enter your variable!");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a + 1);
                    break;
                case "real":
                    Console.WriteLine("Please, enter your variable!");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine(b + 1);
                    break;
                case "text":
                    Console.WriteLine("Please, enter your variable!");
                    string c = (Console.ReadLine());
                    Console.WriteLine(c + "*");
                    break;
                default:
                    break;
            }
        }
    }
}
