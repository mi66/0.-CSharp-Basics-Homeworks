using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace R1S
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Random randomNumbers = new Random();

            for (int i = 1; i <= n; i++)
            {
                Console.Write(randomNumbers.Next(1, n + 1) + " ");   // n+1 ??? all numbers just once
            }

            Console.WriteLine();
        }
    }
}
