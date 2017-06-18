using System;

namespace Company_info
{
    class Company_info
    {
        static void Main()
        {
            Console.WriteLine("Please, enter the information about your company and its manager!");
            Console.Write("Company name:");
            string a = (Console.ReadLine());
            Console.Write("Company address:");
            string b = (Console.ReadLine());
            Console.Write("Phone number:");
            string c = (Console.ReadLine());
            Console.Write("Fax number:");
            string d = (Console.ReadLine());
            Console.Write("Web site:");
            string e = (Console.ReadLine());
            Console.Write("Manager first name:");
            string f = (Console.ReadLine());
            Console.Write("Manager last name:");
            string g = (Console.ReadLine());
            Console.Write("Manager age:");
            string h = (Console.ReadLine());
            Console.Write("Manager phone:");
            string i = (Console.ReadLine());
            Console.WriteLine("Your company name is:{0}\nCompany address:{1}\nPhone number:{2}", a, b, c);
            if (d == "")
            {
                Console.WriteLine("Fax number:no fax");
            }
            else
            {
                Console.WriteLine("Fax number:{0}", d);
            }
            Console.WriteLine("Web site:{0}\nManager first name:{1}\nManager last name:{2}\nManager age:{3}\nManager phone:{4}", e, f, g, h, i);
        }
    }
}
