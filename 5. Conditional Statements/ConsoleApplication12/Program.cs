using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)

        {
            double hour = double.Parse(Console.ReadLine());
            if (hour < 0 || hour > 12 || hour % 1 != 0)
            {
                do
                {
                    Console.WriteLine("Invalid entry. Please enter a digit between 0 and 12");
                    hour = double.Parse(Console.ReadLine());
                } while (hour < 0 || hour > 12 || hour % 1 != 0);
            }
            Console.WriteLine("Enter Minutes");
            double minutes = double.Parse(Console.ReadLine());
            if (minutes < 0 || minutes > 59 || minutes % 1 != 0)
            {
                do
                {
                    Console.WriteLine("Invalid entry. Please enter a digit between 0 and 59");
                    hour = double.Parse(Console.ReadLine());
                } while (minutes < 0 || minutes > 59 || minutes % 1 != 0);
            }
            Console.WriteLine("Enter time of day AM/PM");
            string TOD = (Console.ReadLine());
            if (TOD != "PM" && TOD != "AM")
            {
                do
                {
                    Console.WriteLine("Invalid entry. Please enter AM or PM");
                    TOD = (Console.ReadLine());
                } while (TOD != "PM" && TOD != "AM");
            }
        }
    }
}
