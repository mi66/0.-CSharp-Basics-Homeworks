using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PointinaCircle
{
    static void Main()
    {
        Console.WriteLine("Enter the x-coordinate of the dot and press enter");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the y-coordinate of the dot and press enter");
        double y = double.Parse(Console.ReadLine());
        if ((Math.Pow(x, 2.0) + Math.Pow(y, 2.0)) <= 4)
        {
            Console.WriteLine("The dot is inside the circle");
        }
        else
        {
            Console.WriteLine("The dot is outside the circle");
        }
    }
}