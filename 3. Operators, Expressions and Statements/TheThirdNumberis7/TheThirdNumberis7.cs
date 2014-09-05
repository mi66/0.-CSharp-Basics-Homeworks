using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TheThirdNumberis7
{
    static void Main()
    {
        Console.WriteLine("Insert number and press enter");
        double a = double.Parse(Console.ReadLine());
        double b;
        double c;
        double d;
        b = a / 100;
        c = Math.Floor(b);
        d = c - 7;
        if (d % 10 == 0)
        {
            Console.WriteLine("The third number is 7");
        }
        else
        {
            Console.WriteLine("The third number is not 7");
        }
    }
}