using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Trapezoid
{
    static void Main()
    {
        bool c = true;
        Console.WriteLine("Insert a trapezoid's bottom side and press enter");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert a trapezoid's top side and press enter");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert a trapezoid's height and press enter");
        double h = double.Parse(Console.ReadLine());
        c = ((a > 0) && (b > 0) && (h > 0));
        if (c)
        {
            double area = (a + b) * h / 2;
            Console.WriteLine("Trapezoid's area is {0}", area);
        }
        else
        {
            Console.WriteLine("Please give correct sides and height");
        }
    }
}