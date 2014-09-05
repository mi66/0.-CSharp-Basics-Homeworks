using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NNUM
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double y=0.0;
            double x=0.0;
            double zero = 0;
            double u = -1/zero;           // - infinity
            double o = 1/zero;            // + infinity
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine()); ;
            do
            {
                if (n < 0)
                {
                    Console.WriteLine("Invalid entry. Please re-enter");
                    n = int.Parse(Console.ReadLine());
                }
            } while (n < 0);
            
            for (int i = 1; i <= n; i++)
            {
                do
                {
                    i += 1;
                    Console.WriteLine("Enter a new number");
                    x = double.Parse(Console.ReadLine());
                    y += x;                              // sum of x-s
                    if (u<x) {u=x;}
                    if (o>x) {o=x;}
                } while (i <= n);
                Console.WriteLine("The sum is {0}",Math.Round(y,2));
                Console.WriteLine("The average is {0}", Math.Round(y / n,2));
                Console.WriteLine("The max is {0}", Math.Round(u,2));
                Console.WriteLine("The min is {0}", Math.Round(o,2));
            }
        }
    }
}
