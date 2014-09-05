using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Insert any four digit number and press enter");
        int e = int.Parse(Console.ReadLine());
        if ((e < 1000) || (e > 9999))
        {
            Console.WriteLine("Insert the correct number");
        }
        else
        {
            double f = Convert.ToDouble(e);
            double a = Math.Floor(f / 1000);
            double b = Math.Floor((f - a * 1000)/100);
            double c = Math.Floor((f - a * 1000 - b * 100)/10);
            double d = f - a * 1000 - b * 100 - c * 10;
            double sum = a + b + c + d;
            Console.WriteLine("The sum of the digits is {0}", sum);
            Console.WriteLine("The number in reversed order is {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("The number with the last digit in the first position is {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("The number with the second and the third digits exchanged is {0}{1}{2}{3}", d, c, b, a);
        }
    }
}