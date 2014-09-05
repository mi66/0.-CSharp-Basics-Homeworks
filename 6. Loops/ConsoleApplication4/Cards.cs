using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };    // [] sequence
            int[] colors = { 3, 4, 5, 6 };

            foreach (var card in cards)
            {
                foreach (var color in colors)
                {
                    Console.Write(card);
                    Console.Write((char)color + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
