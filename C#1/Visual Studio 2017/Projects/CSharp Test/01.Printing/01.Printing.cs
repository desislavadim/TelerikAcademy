//Output the exact total amount of money the trainers save for not printing the exams on paper.
using System;

namespace _01.Printing
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the number of students!");
            int students = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the number of paper sheets that should be printed for each student!");
            int sheets = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the price of one realm!");
            double price = double.Parse(Console.ReadLine());

            double numberSheets = students * sheets;
            numberSheets = numberSheets / 500;
            double savedMoney = numberSheets * price;
            Console.Write("The money trainers have saved is: ");
            Console.WriteLine("{0:0.00}",savedMoney);
        }
    }
}