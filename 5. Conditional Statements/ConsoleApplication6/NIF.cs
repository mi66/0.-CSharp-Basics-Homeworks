using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NIF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a >= b && a >= c)
            {
                if (b >= c) Console.WriteLine("{0} {1} {2}", a, b, c);
                else Console.WriteLine("{0} {1} {2}", a, c, b);
            }
            if (b > a && b >= c)
            {
                if (a >= c) Console.WriteLine("{0} {1} {2}", b, a, c);
                else Console.WriteLine("{0} {1} {2}", b, c, a);
            }
            if (c > a && c > b)
            {
                if (b >= a) Console.WriteLine("{0} {1} {2}", c, b, a);
                else Console.WriteLine("{0} {1} {2}", c, a, b);
            }
        }
    }
}
