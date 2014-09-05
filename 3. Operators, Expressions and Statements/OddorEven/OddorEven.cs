using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class OddorEven
{
    static void Main()
    {
        bool a = true;
        Console.WriteLine("Insert any integer number from -2,147,483,648 to 2,147,483,647 and press enter");
        int b = int.Parse(Console.ReadLine());
        a = (b % 2 == 0);
        if (a)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
    }
}
