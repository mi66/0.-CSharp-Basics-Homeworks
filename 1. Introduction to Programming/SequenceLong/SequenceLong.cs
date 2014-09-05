using System;

class SequenceLong
{
    public static double Sequence1(double n)
    {
        double a = 1;
        double b = 1;

        for (double i = 0; i < n; i++)
        {
            a = a + 1;

            b = a * (Math.Pow(-1, a));
        }
        return b;
    }
    static void Main()
    {
        for (double i = 1; i <= 1000; i++)
        {
            Console.WriteLine(Sequence1(i));
        }
    }
}
//             (1+x)
// y = (1+x)(-1)
// x [1,1000]