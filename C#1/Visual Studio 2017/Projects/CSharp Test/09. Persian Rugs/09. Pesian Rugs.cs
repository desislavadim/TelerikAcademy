using System;

namespace _09.Persian_Rugs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the height of the first two triangles!");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the distance between the smaller triangle and the larger triangle!");
            int D = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Your persian rug:");
            Console.WriteLine();

            int width = 2 * N + 1;

            for (int row = 0; row < N; row++)
            {
                Console.Write(new string('#', row));
                Console.Write('\\');

                int spaceleft = width - 2 * row - 2 * D - 2;
                if (spaceleft >= 2)
                {
                    Console.Write(new string(' ', D));
                    Console.Write('\\');
                    Console.Write(new string('.', spaceleft - 2));
                    Console.Write('/');
                    Console.Write(new string(' ', D));
                }
                else
                {
                    Console.Write(new string(' ', width - 2 * row - 2));
                }

                Console.Write('/');
                Console.Write(new string('#', row));

                Console.WriteLine();
            }

            Console.WriteLine(new string('#', N) + 'X' + new string('#', N));

            for (int row = N - 1; row >= 0; row--)
            {
                Console.Write(new string('#', row));
                Console.Write('/');

                int spaceleft = width - 2 * row - 2 * D - 2;
                if (spaceleft >= 2)
                {
                    Console.Write(new string(' ', D));
                    Console.Write('/');
                    Console.Write(new string('.', spaceleft - 2));
                    Console.Write('\\');
                    Console.Write(new string(' ', D));
                }
                else
                {
                    Console.Write(new string(' ', width - 2 * row - 2));
                }

                Console.Write('\\');
                Console.Write(new string('#', row));

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}