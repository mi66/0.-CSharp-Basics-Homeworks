using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Threenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            string a1;
            double b;
            string b1;
            double c;
            string c1;
            Console.WriteLine("Enter three numbers");
            a1 = Console.ReadLine();
            b1 = Console.ReadLine();
            c1 = Console.ReadLine();
            a = Convert.ToDouble(a1);
            b = Convert.ToDouble(b1);
            c = Convert.ToDouble(c1);
            Console.WriteLine("{0}+{1}+{2}={3}",a,b,c,a+b+c);
        }
    }
}
