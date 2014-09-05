using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fsum
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the desired integer");
            int a = int.Parse(Console.ReadLine());
            double b = 0.0;
            for (int i = 0; i <= a; i++)
            {
                b += i;
            }
            Console.WriteLine("The sum of all integers from 0 to {0} is {1}",a,b);

        }
    }
} 

