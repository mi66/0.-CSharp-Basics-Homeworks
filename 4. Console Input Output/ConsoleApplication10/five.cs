using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = int.Parse(Console.ReadLine());
            decimal c = Math.Max(a,b);
            decimal d = Math.Min(a,b) - 1;         //???
            
            decimal e = Math.Floor(c / 5);
            decimal f = Math.Floor(d / 5);
            Console.WriteLine("The numbers which can be divided by 5 in this interval are {0}", e-f);
        }
    }
}
