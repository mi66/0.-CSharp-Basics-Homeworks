﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OEP
{
    class Program
    {
        static void Main(string[] args)
        {
            int even = 1;
            int odd = 1;

            string readNumbers = Console.ReadLine();
            string[] numbers = readNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            // sequence                                sequence
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(numbers[i]);

                if (i % 2 == 0)     //2nd sequence
                {
                    even *= number;    // factorial princip
                }
                else
                {
                    odd *= number;
                }
            }

            if (even == odd)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = " + even);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = " + odd);
                Console.WriteLine("even_product = " + even);
            }
        }
    }
}
