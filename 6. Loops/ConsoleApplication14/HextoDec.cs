using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter you hexadecimal value: ");
            string hexa = Console.ReadLine();

            long dec = long.Parse(hexa, NumberStyles.HexNumber);     //to Hex

            Console.WriteLine(dec);
        }
    }
}
