using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Big5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the five numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double f;
            if (Math.Max(a, b) >= Math.Max(d, c)) f = Math.Max(a, b);
            else f = Math.Max(d, c);
            if (f >= e) Console.WriteLine("The biggest of the five numbers is {0}",f);
            else Console.WriteLine("The biggest of the five numbers is {0}",e);
        }
    }
}
