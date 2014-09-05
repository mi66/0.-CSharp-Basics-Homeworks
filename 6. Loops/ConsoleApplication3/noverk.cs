using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 1.0;
            double x = 1.0;
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine()); ;
            do
            {
                if (n < 0)
                {
                    Console.WriteLine("Invalid entry. Negative integers do not have factorials. Please re-enter");
                    n = int.Parse(Console.ReadLine());
                }
            } while (n < 0);
            Console.WriteLine("Enter number");
            int k = int.Parse(Console.ReadLine()); ;
            do
            {
                if (k < 0)
                {
                    Console.WriteLine("Invalid entry. Negative integers do not have factorials. Please re-enter");
                    k = int.Parse(Console.ReadLine());
                }
            } while (k < 0);

            for (int i = 1; i <= n; i++)
            {
                do
                {
                    i += 1;
                    y *= i;       //factotial

                } while (i < n);
                
            }
            for (int j = 1; j <= k; j++)
            {
                do
                {
                    j += 1;
                    x *= j;

                } while (j < k);

            }
            if (n <= k) Console.WriteLine(x/y);
            if (k <= n) Console.WriteLine(y / x);
   
        }
    }
}