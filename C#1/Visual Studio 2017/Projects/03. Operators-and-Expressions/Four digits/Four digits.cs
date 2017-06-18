using System;

namespace Four_digits
{
    class Four_digits

    {
        static void Main()
        {
            Console.WriteLine("Please, enter a four-digit number!");
            int num = int.Parse(Console.ReadLine());
            int firstDigit = num / 1000;
            int secondDigit = (num / 100) % 10;
            int thirdDigit = (num / 10) % 10;
            int forthDigit = num % 10;
            int p = firstDigit + secondDigit + thirdDigit + forthDigit;
            Console.WriteLine("The sum of the digits is:" + p);
            Console.WriteLine("The reversed number is:{0}{1}{2}{3}", forthDigit, thirdDigit, secondDigit,firstDigit);
            Console.WriteLine("The last digit in the first position is:{0}{1}{2}{3}", forthDigit,firstDigit, secondDigit, thirdDigit);
            Console.WriteLine("Exchanged second and third digit is:{0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, forthDigit);
        }
    }
}
