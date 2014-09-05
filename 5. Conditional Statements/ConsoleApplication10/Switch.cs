using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont;
            do
            {
            Console.WriteLine("Please choose a type:\n 1--> int\n 2--> double\n 3--> string");
            string choice = (Console.ReadLine());
            switch (choice)
            {
                
                case "1": 
                    Console.WriteLine("Please enter an integer"); 
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a+1);
                    break;
                case "2": 
                    Console.WriteLine("Please enter a number"); 
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine(b+1);
                    break;
                case "3": 
                    Console.WriteLine("Enter a string");
                    string c = Console.ReadLine() + "*";
                    Console.WriteLine(c);
                    break;
                default: Console.WriteLine("invalid choice"); break;
            }
                Console.WriteLine("Continue Y/N");
                cont = Console.ReadLine();
            } while(cont=="Y");
        }
    }
}
