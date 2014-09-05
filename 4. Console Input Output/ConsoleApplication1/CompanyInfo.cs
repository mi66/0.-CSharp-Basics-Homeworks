using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string LastName;
            string CompanyName;
            string age;
            string fax;
            string site;
            double age1;
            string phone;
            string address;
            string manphone;


            Console.WriteLine("Enter the manager's first name and press enter");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter the manager's last name and press enter");
            LastName = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter the manager's age in digits and press enter");
                age = Console.ReadLine();
                age1 = Convert.ToDouble(age);
                if (age1 > 120 || age1 < 0) Console.WriteLine("Invalid age. Please re-enter your age and press enter");
            } while (age1 > 120 || age1 < 0);
            Console.WriteLine("Enter the manager's phone number and press enter");
            manphone = Console.ReadLine();
            Console.WriteLine("Enter the company's name and press enter");
            CompanyName = Console.ReadLine();
            Console.WriteLine("Enter the company's phone number and press enter");
            phone = Console.ReadLine();
            Console.WriteLine("Enter the company's fax number and press enter");
            fax = Console.ReadLine();
            Console.WriteLine("Enter the company's address and press enter");
            address = Console.ReadLine();
            Console.WriteLine("Enter the company's website address and press enter");
            site = Console.ReadLine();
            
            Console.WriteLine("{0,-30}| {1, -30}", "Company Name",CompanyName);            // Table
            Console.WriteLine("{0,-30}| {1, -30}", "Address:", address);
            Console.WriteLine("{0,-30}| {1, -30}","Telephone:", phone);
            Console.WriteLine("{0,-30}| {1, -30}","Fax:", fax);
            Console.WriteLine("{0,-30}| {1, -30}","Website:", site);
            Console.WriteLine("{0,-30}| {1, -30}", "Manager's first name:",FirstName);
            Console.WriteLine("{0,-30}| {1, -30}","Manager's last name:", LastName);
            Console.WriteLine("{0,-30}| {1, -30}","Manager's age", age1);
            Console.WriteLine("{0,-30}| {1, -30}","Manager's phone:", manphone);


        }
    }
}
