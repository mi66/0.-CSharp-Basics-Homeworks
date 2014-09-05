using System;

class CheckBitPosition
{
    static void Main()
    {
        int a;
        Console.WriteLine("Enter an unsigned integer");
        a = int.Parse(Console.ReadLine());
        while (a < 0)
        {
            Console.WriteLine("You have entered invalid number");
            Console.WriteLine("Enter an unsigned integer");
            a = int.Parse(Console.ReadLine());
        }
        int p;
        Console.WriteLine("Enter an p index integer");
        p = int.Parse(Console.ReadLine());
        while ((p < 0) || (p > 31))
        {
            Console.WriteLine("You have entered invalid number");
            Console.WriteLine("Enter an unsigned integer");
            p = int.Parse(Console.ReadLine());
        }
        int v;
        Console.WriteLine("Enter an v value (0 or 1) for the position p");
        v = int.Parse(Console.ReadLine());
        while ((v < 0) || (v > 1))
        {
            Console.WriteLine("You have entered invalid value");
            Console.WriteLine("Enter an v value (0 or 1) for the position p");
            v = int.Parse(Console.ReadLine());
        }
        if (v == 1)
        {
            int x;
            int b = 1;
            x = (b << p);
            int y;
            y = a & x;
            Console.WriteLine("The number {0} with value {1} at the position {2} becomes {3}", a, v, p, y);
        }
        else
        {
            int j;
            int w = 1;
            j = ~(w << p);
            int z;
            z = a & j;
            Console.WriteLine("The number {0} with value {1} at the position {2} becomes {3}", a, v, p, z);
        }
    }
}