//Using loops write a program that converts a hexadecimal integer number to its decimal form.
using System;

namespace _14.Hex_to_Decimal
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number in hexadecimal system!");
            string str = Console.ReadLine();
            //int number = Convert.ToInt32(str, 16);

            double sum = 0;

            int num = Int32.Parse(str);
            //Console.WriteLine(num);
            for (int i = 0; num > 0; i++)
            {
                int lastDigit = num % 10;
                
                string a = lastDigit.ToString();
                if (a == "A")
                {
                    lastDigit = 10;
                }
                else
                {
                    if (a == "B")
                    {
                        lastDigit = 11;
                    }
                    else
                    {
                        if (a == "C")
                        {
                            lastDigit = 12;
                        }
                        else
                        {
                            if (a == "D")
                            {
                                lastDigit = 13;
                            }
                            else
                            {
                                if (a == "E")
                                {
                                    lastDigit = 14;
                                }
                                else
                                {
                                    if (a == "F")
                                    {
                                        lastDigit = 15;
                                    }
                                }
                            }
                        }
                    }
                }
                sum = sum + lastDigit * (Math.Pow(16, i));
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
// NOT COMPLETED