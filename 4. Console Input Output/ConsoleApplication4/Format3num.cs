using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormatNUm3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string a1;
            float b;
            string b1;
            float c;
            string c1;
            Console.WriteLine("Enter three numbers");
            a1 = Console.ReadLine();
            b1 = Console.ReadLine();
            c1 = Console.ReadLine();
            a = Convert.ToInt32(a1);
            b = float.Parse(b1);
            c = float.Parse(c1);
            string d = Convert.ToString(a, 2);
            string e = d.PadLeft(10,'0');            // left aligned
            Console.WriteLine("{0,-10:X}|{3,10}|{2,10:F2}|{2, -10:F3}",a,b,c,e);
        }                    // {index[,alignment][:formatString]} - represents as a unicode
    }                        // 0,10:G - decimal                    Convert.ToString(a, 2) ----> 0100011110000
}                            // 0,10:X - hexadecimal
                             // 0,10:F2 - 2 digits after point
                             // 0,10:F3 - 3 digits after point
                             // 0,10:C - currency