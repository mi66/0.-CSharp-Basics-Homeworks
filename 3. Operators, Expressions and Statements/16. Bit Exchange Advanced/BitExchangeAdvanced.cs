using System;

class Program
{
    static void Main(string[] args)
    {
        string yyy;
        do
        {

            long n;
            int p;
            int q;
            int k;
            string n1, p1, q1, k1;
            long r;
            long r2;
            Console.WriteLine("Enter number and press enter");
            n1 = Console.ReadLine();
            n = Convert.ToInt64(n1);
            do
            {
                Console.WriteLine("Enter p (between 0 and 31 included) and press enter");
                p1 = Console.ReadLine();
                p = Convert.ToInt32(p1);
                if (p < 0 || p > 31) Console.WriteLine("Invalid value. Please re-enter");
            } while (p < 0 || p > 31);
            do
            {
                Console.WriteLine("Enter q (between 0 and 31 included) and press enter");
                q1 = Console.ReadLine();
                q = Convert.ToInt32(q1);
                if (q < 0 || q > 31 || q == p) Console.WriteLine("Invalid value. Please re-enter");
            } while (p < 0 || p > 31 || q == p);
            do
            {
                Console.WriteLine("Enter k (between 0 and 31 included) and press enter");
                k1 = Console.ReadLine();
                k = Convert.ToInt32(k1);
                if (k < 0 || (k - 1 + p) > 31 || (k - 1 + q) > 31 || (p < q && k - 1 + p >= q) || (p > q && k - 1 + q >= p)) Console.WriteLine("Invalid value. Please re-enter while keeping in mind that the intervasls should not overlap");
            } while (k < 0 || (k - 1 + p) > 31 || (k - 1 + q) > 31 || (p < q && k - 1 + p >= q) || (p > q && k - 1 + q >= p));
            if (k > 0)
            {
                double m = ((Math.Pow(2.0, k)) - 1);
                long m1 = (long)m;
                long s = (m1 << p);
                long s2 = (m1 << q);
                long l = (s & n);
                long l2 = (s2 & n);
                long inv1 = ~s;
                long inv2 = ~s2;
                long inv3 = (n & inv1);
                long inv4 = (inv2 & inv3);
                if (p > q)
                {
                    r = (l >> (p - q));
                    r2 = (l2 << (p - q));
                }
                else
                {
                    r = (l << (q - p));
                    r2 = (l2 >> (q - p));
                }
                long z = inv4 + r + r2;
                Console.WriteLine(z);
            }
            else
            {
                double m = 1;
                long m1 = (long)m;
                long s = (m1 << p);
                long s2 = (m1 << q);
                long l = (s & n);
                long l2 = (s2 & n);
                long inv1 = ~s;
                long inv2 = ~s2;
                long inv3 = (n & inv1);
                long inv4 = (inv2 & inv3);
                if (p > q)
                {
                    r = (l >> (p - q));
                    r2 = (l2 << (p - q));
                }
                else
                {
                    r = (l << (q - p));
                    r2 = (l2 >> (q - p));
                }
                long z = inv4 + r + r2;
                Console.WriteLine(z);


            }
            Console.WriteLine("Do you wish to continue Y/N");
            yyy = Console.ReadLine();
        } while (yyy == "Y");
    }
}
