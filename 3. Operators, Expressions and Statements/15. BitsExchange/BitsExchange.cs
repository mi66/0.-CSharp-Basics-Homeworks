using System;

class BitsExchange
{
    static void Main()
    {
        long n;
        string a;
        Console.WriteLine("Enter number and press enter");
        a = Console.ReadLine();
        n = Convert.ToInt64(a);
        //long m = 7;                   // mask 111 (7)
        //long s = (m << 24);           // mask for the first 3 digists
        //long s2 = (m << 3);           // mask for the second 3 digists
        //long l = (s & n);             // number given & mask1
        //long l2 = (s2 & n);           // number given & mask2
        //long r = (l >> 21);           // aftermask exchange
        //long r2 = (l2 << 21);         // aftermask exchange
        //long inv1 = ~s;               // antimask1
        //long inv2 = ~s2;              // antimask2
        //long inv3 = (n & inv1);       // number given & antimask1
        //long inv4 = (inv2 & inv3);    // number given & antimask1 & antimask 2
        //long z = inv4 + r + r2;       // sum of aftermasks and number after antimasks
        //Console.WriteLine(z);

        //or
        long m = 7;                   // mask 111 (7)
        long s = (m << 24);           // mask for the first 3 digists
        long s2 = (m << 3);           // mask for the second 3 digists
        long l = (s & n);             // number given & mask1
        long l2 = (s2 & n);           // number given & mask2
        long r = (l >> 21);           // aftermask exchange
        long r2 = (l2 << 21);         // aftermask exchange
        long z = (n - (l + l2)) + (r + r2);
        Console.WriteLine(z);
    }
}