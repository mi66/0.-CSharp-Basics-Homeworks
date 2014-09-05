using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 5 numbers with spaces between them and press enter");
            string a = Console.ReadLine();
            decimal sum = 0.00m;
            string[] numbers = a.Split(' ');            //substrings
            for (int i = 0; i < numbers.Length; i++)    //represents the total number of elements in the string 
            {
                sum += decimal.Parse(numbers[i]);
            }
            Console.WriteLine("The sum is {0}",sum);
       }
    }
}
