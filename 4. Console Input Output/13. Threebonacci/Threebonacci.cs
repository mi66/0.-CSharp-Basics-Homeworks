using System;

class Threebonacci
{
    static void Main()
    {
        Console.WriteLine("Enter first 3 numbers of the threebonacci sequence");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the serial number of the element in the sequence given");
        int s = int.Parse(Console.ReadLine());
        for (int i = 0; i <= s; i++);
        {
            int temp = a;
            a = b;
            b = c;
            c = temp + a + b;
        }
        Console.WriteLine("The {0}th number in this sequence is {1}", s, c);
    }
}