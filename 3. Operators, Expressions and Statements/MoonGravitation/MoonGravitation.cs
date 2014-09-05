using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MoonGravitation
{
    static void Main()
    {
        bool a = true;
        Console.WriteLine("Insert your weight using dot to separate kilograms and grams. Press enter");
        double b = double.Parse(Console.ReadLine());
        a = (b > 0);
        if (a)
        {
            double c = b * 0.17;
            Console.WriteLine("Your weight on the Moon is approximately {0}", c);
        }
        else
        {
            Console.WriteLine("Oooooh!!! That's can't be your weight. Try again");
        }
    }
}
