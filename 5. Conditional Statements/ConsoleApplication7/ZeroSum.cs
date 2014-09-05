using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroSum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string k;
            do
            {
                Console.WriteLine("Enter the five numbers");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
                double e = double.Parse(Console.ReadLine());
                if ((a + b + c + d + e) == 0) Console.WriteLine("{0}+{1}+{2}+{3}+{4}={5}", a, b, c, d, e, 0);
                if ((a + b + c + d) == 0) Console.WriteLine("{0}+{1}+{2}+{3}={4}", a, b, c, d, 0);
                if (((a + b + c + e) == 0)&&(e!=d)) Console.WriteLine("{0}+{1}+{2}+{3}={4}", a, b, c, e, 0);
                if (((a + b + e + d) == 0)&&(d!=c)) Console.WriteLine("{0}+{1}+{2}+{3}={4}", a, b, d, e, 0);
                if (((a + e + c + d) == 0)&&(c!=b)) Console.WriteLine("{0}+{1}+{2}+{3}={4}", a, c, d, e, 0);
                if (((e + b + c + d) == 0)&&(a!=b)) Console.WriteLine("{0}+{1}+{2}+{3}={4}", b, c, d, e, 0);
                if ((a + b + c) == 0) Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, 0);
                if (((a + b + d) == 0)&&(c!=d)) Console.WriteLine("{0}+{1}+{2}={3}", a, b, d, 0);
                if (((a + b + e) == 0)&&(e!=d)) Console.WriteLine("{0}+{1}+{2}={3}", a, b, e, 0);
                if (((a + c + d) == 0)&&(c!=b)) Console.WriteLine("{0}+{1}+{2}={3}", a, c, d, 0);
                if (((a + c + e) == 0)&&(e!=d)) Console.WriteLine("{0}+{1}+{2}={3}", a, c, e, 0);
                if (((a + d + e) == 0)&&(c!=d)) Console.WriteLine("{0}+{1}+{2}={3}", a, d, e, 0);
                if (((b + c + d) == 0)&&(a!=b)) Console.WriteLine("{0}+{1}+{2}={3}", b, c, d, 0);
                if (((b + c + e) == 0)&&(e!=d)) Console.WriteLine("{0}+{1}+{2}={3}", b, c, e, 0);
                if (((b + d + e) == 0)&&(c!=d)) Console.WriteLine("{0}+{1}+{2}={3}", b, d, e, 0);
                if (((c + d + e) == 0)&&(c!=b)) Console.WriteLine("{0}+{1}+{2}={3}", c, d, e, 0);
                if ((a + b) == 0) Console.WriteLine("{0}+{1}={2}", a, b, 0);
                if (((a + c) == 0)&&(c!=b)) Console.WriteLine("{0}+{1}={2}", a, c, 0);
                if (((a + d) == 0)&&(c!=d)) Console.WriteLine("{0}+{1}={2}", a, d, 0);
                if (((a + e) == 0)&&(e!=d)) Console.WriteLine("{0}+{1}={2}", a, e, 0);
                if (((b + c) == 0)&&(a!=b)) Console.WriteLine("{0}+{1}={2}", b, c, 0);
                if (((b + d) == 0)&&(c!=d)) Console.WriteLine("{0}+{1}={2}", b, d, 0);
                if (((b + e) == 0)&&(e!=d)) Console.WriteLine("{0}+{1}={2}", b, e, 0);
                if (((c + d) == 0)&&(c!=b)) Console.WriteLine("{0}+{1}={2}", c, d, 0);
                if (((c + e) == 0)&&(e!=d)) Console.WriteLine("{0}+{1}={2}", c, e, 0);
                if (((d + e) == 0)&&(c!=d)) Console.WriteLine("{0}+{1}={2}", d, e, 0);
                if (((a + b + c + d + e) != 0) && ((a + b + c + d) != 0) && ((a + b + c + e) != 0) && ((a + b + e + d) != 0) && ((a + e + c + d) != 0) && ((e + b + c + d) != 0) && ((a + b + c) != 0) && ((a + b + d) != 0) && ((a + b + e) != 0) && ((a + c + d) != 0) && ((a + c + e) != 0) && ((a + d + e) != 0) && ((b + c + d) != 0) && ((b + c + e) != 0) && ((b + d + e) != 0) && ((c + d + e) != 0) && ((a + b) != 0) && ((a + c) != 0) && ((a + d) != 0) && ((a + e) != 0) && ((b + c) != 0) && ((b + d) != 0) && ((b + e) != 0) && ((c + d) != 0) && ((c + e) != 0) && ((d + e) != 0)) Console.WriteLine("No Zero Subset");
                Console.WriteLine("Continue Y/N");
                k = Console.ReadLine();
            }
            while (k == "Y");
           
        }
    }
}
