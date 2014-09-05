using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnetoN
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            Console.WriteLine("Enter number");
            int n=int.Parse(Console.ReadLine());;
            do
            {
                if (n < 0)
                {
                    Console.WriteLine("Invalid entry. Please re-enter");
                    n = int.Parse(Console.ReadLine());
                }
            } while (n<0);
            while (i<=n)
            {
                Console.Write("{0} ",i++);
            }


        }
    }
}
