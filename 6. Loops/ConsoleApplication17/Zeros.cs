using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int zeros = 0;
            int five = 5;
            while (five <= n)
            {
                zeros += n / five;
                five = five * 5;
            }
            Console.WriteLine(zeros);
        }
    }
}
