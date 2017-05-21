using System;


class SafeCompare
{
    static void Main()
    {
        Console.WriteLine("Please enter the first real number:");
        float number1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the second real number:");
        float number2 = float.Parse(Console.ReadLine());

        Console.WriteLine("The two numbers are: {0} and {1}", number1, number2);

        if (number1 == number2)
        {
            Console.WriteLine("The numbers are equal with precision of 0.000001");
        }
        else
        {
            Console.WriteLine("The numbers are not equal with the required precision of 0.000001");
        }
    }
}
