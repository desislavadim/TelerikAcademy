using System;


namespace MMSA_of_N_Numbers
{
    class MMSA_of_N_Numbers
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number!");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter {0} numbers!", num);
            double sum = 0;
            double avg = 0;
            double min = 0; 
            double max = 0;
            int a = 0;
            for (int i = 0; i < num; i++)
            {
                int a1 = a;
                a = int.Parse(Console.ReadLine());
                max = Math.Max(a, a1);
                min = Math.Min(a, a1);
                sum += a;


            }
            avg = sum / num;
            Console.WriteLine("min = {0:0.00}", min);
            Console.WriteLine("max = {0:0.00}", max);
            Console.WriteLine("sum = {0:0.00}", sum);
            Console.WriteLine("avg = {0:0.00}", avg);
        }
    }
}
