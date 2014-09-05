using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int a;
        int p;
        int x;
        int n = 1;
        Console.WriteLine("Enter any unsigned integer and press enter");
        a = int.Parse(Console.ReadLine());
        while (a < 0)
        {
            Console.WriteLine("The number you have entered is invalid");
            Console.WriteLine("Enter any unsigned integer and press enter");
            a = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Insert p index");
        p = int.Parse(Console.ReadLine());
        while ((p < 0) || (p > 15))
        {
            Console.WriteLine("The p index you have entered is invalid");
            Console.WriteLine("Insert p index");
            p = int.Parse(Console.ReadLine());
        }
        x = (a >> p);
        Console.WriteLine(x & n);
    }
}