using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1;
            string b1;
            double a;
            double b;
            Console.WriteLine("Enter the two numbers");
            a1 = Console.ReadLine();
            b1 = Console.ReadLine();
            a = Convert.ToDouble(a1);
            b = Convert.ToDouble(b1);
            Console.WriteLine(Math.Max(a, b));     //greater number
                  
        }
    }
}
