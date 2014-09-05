using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Big3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (Math.Max(a, b) >= Math.Max(a, c)) Console.WriteLine(Math.Max(a, b));
            else Console.WriteLine(Math.Max(a, c));
        }
    }
}
