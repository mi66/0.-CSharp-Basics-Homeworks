using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i;
            double x = 0.0;
            Console.WriteLine("Enter how many numbers you want to sum up");
            n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Invalid quantity. Enter how many numbers you want to sum up");
                n = int.Parse(Console.ReadLine());
            }
            for (i = 1; i <= n; i++)
            {
                do
                {
                    i += 1;
                    Console.WriteLine("Enter a new number");
                    x += double.Parse(Console.ReadLine());
                } while (i <= n);
                Console.WriteLine("The sum of {0} numbers is {1}", n, x);
            }

            //Console.WriteLine("Enter the desired integer");
            //int a = int.Parse(Console.ReadLine());
            //double x = 0.0;
            //for (int i = 1; i <= a; i++)
            //{
            //    do
            //    {
            //        i += 1;
            //        Console.WriteLine("Enter a new number");
            //        x += double.Parse(Console.ReadLine());
            //    } while (i <= a);
            //    Console.WriteLine(x);
            //}
        }
    }
}