using System;

namespace Age
{
    class Program
    {
        static void Main()
        {
            string date = Console.ReadLine();//12.03.2012
            DateTime dateObject = DateTime.Parse(date);
            dateObject = dateObject.AddYears(10);

            Console.WriteLine(dateObject);
        }
    }
}
