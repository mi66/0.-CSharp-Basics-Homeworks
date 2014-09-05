using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Divisionby7and5
{
    static void Main()
    {
        bool a = true;
        Console.WriteLine("Insert an integer number and press enter");
        int b = int.Parse(Console.ReadLine());
        a = ((b % 5 == 0) && (b % 7 == 0));
        if (a)
        {
            Console.WriteLine("The integer given can be divided without a remainder by 7 and 5 at the same time");
        }
        else
        {
            Console.WriteLine("The integer given cannot be divided without a remainder by 7 and 5 at the same time");
        }
    }
}
