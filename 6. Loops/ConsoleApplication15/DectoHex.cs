using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace DectoHex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your decimal number: ");
            long dec = long.Parse(Console.ReadLine());

            string hexaStr = dec.ToString("X");                //dec to hex using str

            long hexa = long.Parse(hexaStr, NumberStyles.HexNumber);

            Console.WriteLine(hexaStr);
        }
    }
}
