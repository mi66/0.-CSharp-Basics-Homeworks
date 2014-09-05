using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a, b, c");
           double a = double.Parse(Console.ReadLine());
           double b = double.Parse(Console.ReadLine());
           double c = double.Parse(Console.ReadLine());
           double d = (Math.Pow(b, 2) - (4 * a * c));
            if (d==0)
                { double x = -b/(2*a);
                    Console.WriteLine("The quadratic equation has only one root and that is {0}",x);
                }
            if (d<0) {Console.WriteLine("The quadratic equation has no real roots");}
            if (d > 0)
            {
                double x1 = ((-b + Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b - Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("The roots of the equation are {0} and {1}", x1, x2);
            }
        }
    }
}
