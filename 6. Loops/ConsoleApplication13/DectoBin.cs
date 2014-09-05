using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DectoBin
{
    class Program
    {
        static void Main(string[] args)
        {
            //decimal a = decimal.Parse(Console.ReadLine());
            //long c = (long)a;
            //string d = Convert.ToString(c, 2);
            //Console.WriteLine(d);
            int decimalNumber = int.Parse(Console.ReadLine());
            int modulRest;
            string binary = "";
            if (decimalNumber == 0)
            {
                Console.WriteLine(decimalNumber);
            }
            else
            {
                while (decimalNumber > 0)
                {
                    modulRest = decimalNumber % 2;
                    decimalNumber = decimalNumber / 2;
                    binary = modulRest.ToString() + binary;
                }
                Console.WriteLine(binary);
            }
        }
    }
}