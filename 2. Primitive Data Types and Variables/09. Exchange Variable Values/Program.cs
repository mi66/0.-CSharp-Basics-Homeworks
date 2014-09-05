using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before the exchange a = {0}, b = {1}", a, b);
        int a2 = b;
        int b2 = a;
        Console.WriteLine("Before the exchange a = {0}, b = {1}", a2, b2);
    }
}