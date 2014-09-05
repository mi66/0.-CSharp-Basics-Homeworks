using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExtractBit3
{
    static void Main()
    {
        int a;
        int b = 1;
        int x;
        Console.WriteLine("Enter any unsigned integer");
        a = int.Parse(Console.ReadLine());
        while (a < 0)
        {
            Console.WriteLine("The number you have entered is invalid");
            Console.WriteLine("Enter any unsigned integer");
            a = int.Parse(Console.ReadLine());
        }
        x = (a >> 3);
        Console.WriteLine(x & b);
       }
}