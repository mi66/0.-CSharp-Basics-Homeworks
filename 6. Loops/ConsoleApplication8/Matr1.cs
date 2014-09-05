using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 20)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j <= n + i; j++)
                    {
                        Console.Write("{0,6} ", j);
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
