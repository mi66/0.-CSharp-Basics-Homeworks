using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine()); ;
            do
            {
                if (n < 0)
                {
                    Console.WriteLine("Invalid entry. Please re-enter");
                    n = int.Parse(Console.ReadLine());
                }
            } while (n < 0);
            while (i <= n)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write("{0} ", i++);
                }
                else
                {
                    i++;
                }
            }

        }
    }
}
