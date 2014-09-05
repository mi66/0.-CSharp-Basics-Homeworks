using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your score");
            double a = double.Parse(Console.ReadLine());;
            if (a < 1 || a > 9)
            {
                do
                {
                    { Console.WriteLine("Invalid Score. Please re-enter"); }
                    a = double.Parse(Console.ReadLine()); ;
                } while (a < 1 || a > 9);
            }
            if (a >= 1 && a < 4) { Console.WriteLine("Your score is {0}", a * 10); }
            if (a >= 4 && a < 7) { Console.WriteLine("Your score is {0}", a * 100); }
            if (a >= 7 && a <= 9) { Console.WriteLine("Your score is {0}", a * 1000); }
        }
    }
}
