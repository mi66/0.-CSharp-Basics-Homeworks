using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultSign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three multipliers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if ((a < 0 && b < 0 && c > 0) || (a < 0 && c < 0 && b > 0) || (b < 0 && c < 0 && a > 0) || (b > 0 && c > 0 && a > 0)) Console.WriteLine("The sign is +");
            else if (a == 0 || b == 0 || c == 0) Console.WriteLine("The result is 0");
            else Console.WriteLine("The sign is -");
        }
    }
}
