﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigWor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a digit and press enter");
            string digit = (Console.ReadLine());
            switch (digit)                                          // switch(name)
            {                                                       // {
                case "0": Console.WriteLine("Zero"); break;         //      case "0": Con...; break;
                case "1": Console.WriteLine("One"); break;          //      case "1":
                case "2": Console.WriteLine("Two"); break;
                case "3": Console.WriteLine("Three"); break;        // default: Con...; break;
                case "4": Console.WriteLine("Four"); break;
                case "5": Console.WriteLine("Five"); break;
                case "6": Console.WriteLine("Six"); break;
                case "7": Console.WriteLine("Seven"); break;
                case "8": Console.WriteLine("Eight"); break;
                case "9": Console.WriteLine("Nine"); break;
                default: Console.WriteLine("not a digit"); break;
            }

        }
    }
}
