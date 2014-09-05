using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangeifGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            double b = double.Parse(Console.ReadLine());

            if (a <= b) { Console.WriteLine("{0} {1}", a, b); }
            else { Console.WriteLine("{0} {1}", b, a); }

        }
    }
}
