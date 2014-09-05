using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RNR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("min = ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("max = ");
            int max = int.Parse(Console.ReadLine());

            if (min <= max)
            {
                Random random = new Random();             // random

                for (int i = 0; i < n; i++)
                {
                    Console.Write(random.Next(min, max + 1) + " ");      // +? to include the last number
                }

                Console.WriteLine();
            }
        }
    }
}
