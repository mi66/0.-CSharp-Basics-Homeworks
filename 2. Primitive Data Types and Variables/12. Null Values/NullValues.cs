using System;

class NullValues
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        double? c = 5 + b;
        double? d = null + b;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
    }
}