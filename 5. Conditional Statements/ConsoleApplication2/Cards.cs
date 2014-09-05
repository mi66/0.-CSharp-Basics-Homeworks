using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your card");
            string a = Console.ReadLine();
            if (a.Length == 1)
            {
                if (a.Contains("1") || a.Contains("2") || a.Contains("3") || a.Contains("4") || a.Contains("5") || a.Contains("6") || a.Contains("7") || a.Contains("8") || a.Contains("9") || a.Contains("J") || a.Contains("Q") || a.Contains("K") || a.Contains("A")) Console.WriteLine("This is a valid card");
                else { Console.WriteLine("This is not a valid card"); }
            }
            else if (a.Length == 2)
            {
                if (a.Contains("10")) Console.WriteLine("This is a valid card");
                else { Console.WriteLine("This is not a valid card"); }
            }
            else { Console.WriteLine("This is not a valid card"); }
        }
    }
}
