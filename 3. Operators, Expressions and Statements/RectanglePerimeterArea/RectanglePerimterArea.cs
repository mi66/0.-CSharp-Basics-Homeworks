using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class RectanglePerimeterArea
{
    static void Main()
    {
        bool c = true;
        Console.WriteLine("Insert a rectangle's width and press enter");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Insert a rectangle's height and press enter");
        double b = double.Parse(Console.ReadLine());
        c = ((a > 0) && (b > 0));
        if (c)
        {
            double perimeter = 2 * (a + b);
            double area = a * b;
            Console.WriteLine("Rectanle's perimeter is {0} and area is {1}", perimeter, area);
        }
        else
        {
            Console.WriteLine("Please give correct width and height");
        }
    }
}