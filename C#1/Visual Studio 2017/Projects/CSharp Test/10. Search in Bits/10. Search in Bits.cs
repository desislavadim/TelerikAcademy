﻿using System;

namespace _10.Search_in_Bits
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the number S!");
            int S = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the number N!");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter {0} number(s)!", N);
            int count = 0;

            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());

                for (int pos = 0; pos <= 26; pos++)
                {
                    bool match = true;
                    for (int j = 0; j <= 3; j++)
                    {
                        var posInNum = pos + j;
                        var posInS = j;

                        int bitInNum = (num & (1 << posInNum)) >> posInNum;
                        int bitInS = (S & (1 << posInS)) >> posInS;

                        if (bitInNum != bitInS)
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}