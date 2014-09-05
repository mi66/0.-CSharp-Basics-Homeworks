using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circ
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1;
            double a;
            double pi = 3.14159;
            Console.WriteLine("Enter the circle's radius");
            a1 = Console.ReadLine();
            a = Convert.ToDouble(a1);
            Console.WriteLine("A cicle with a radius {0:F2} has a perimeter of {1:F2} and an area of {2:F2}",a,(a*2*pi),(Math.Pow(a,2.0)*pi));
        }
    }              // {0:F2} - 0.00 2 digits after dot
}
