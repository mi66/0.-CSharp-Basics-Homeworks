using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            while ((p < 0) || (p > 15))
            {
                Console.WriteLine("You have entered invalid number");
                Console.WriteLine("Enter an unsigned integer");
                p = int.Parse(Console.ReadLine());
            }
            int x;
            x = (a >> p);
            int b = 1;
            int y;
            y = x & b;
            if (y == 1)
            {
                Console.WriteLine("True. The numper {0} at the position {1} has value 1", a, p);                
            }
            else
            {
                Console.WriteLine("False. The number {0} at the position {1} has value 0", a, p);
            }
        }
    }