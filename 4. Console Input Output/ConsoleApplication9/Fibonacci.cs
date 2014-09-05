using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Fibonacci
    {
        public static int Fiibonaccii(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            Console.WriteLine("Enter the desired integer");
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine(Fiibonaccii(i));
            }
        }
    }
}
