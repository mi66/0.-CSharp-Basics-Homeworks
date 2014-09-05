using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class CircleandRectangle
    {
        static void Main()
        {
            Console.WriteLine("Enter the x-coordinate of the dot and press enter");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y-coordinate of the dot and press enter");
            double y = double.Parse(Console.ReadLine());
            if ((Math.Pow((x-1), 2.0) + Math.Pow((y-1), 2.0)) <= 2.25)
            {
                if (((x < 5) || (x > (-1))) && ((y < 1) || (y > (-1))))
                    Console.WriteLine("The dot submits the requirements");
                else
                {
                    Console.WriteLine("The dot doesn't submit the requirements");
                }
            }
            else
            {
                Console.WriteLine("The dot doesn't submit the requirements");
            }
        }
    }