//Using loops write a program that converts an integer number to its hexadecimal representation.
using System;

namespace _13.Decimal_to_Hex
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number in decimal system!");
            long num = long.Parse(Console.ReadLine());
            string str = "";
            Console.Write("The hexadecimal representation of {0} is: ", num);
            for (long i = 0; num > 0; i++)
            {
                i = 0;
                i = num % 16;
                num = num / 16;
                if (i == 10)
                {
                    string a = i.ToString();
                    a = "A";
                    str = a + str;
                }
                else
                {
                    if (i == 11)
                    {
                        string a = i.ToString();
                        a = "B";
                        str = a + str;
                    }
                    else
                    {
                        if (i == 12)
                        {
                            string a = i.ToString();
                            a = "C";
                            str = a + str;
                        }
                        else
                        {
                            if (i == 13)
                            {
                                string a = i.ToString();
                                a = "D";
                                str = a + str;
                            }
                            else
                            {
                                if (i == 14)
                                {
                                    string a = i.ToString();
                                    a = "E";
                                    str = a + str;
                                }
                                else
                                {
                                    if (i == 15)
                                    {
                                        string a = i.ToString();
                                        a = "F";
                                        str = a + str;
                                    }
                                    else
                                    {
                                        str = i + str;
                                    }
                                }
                            }
                        }
                    }
                }
                

            }
            Console.WriteLine(str);

        }
    }
}