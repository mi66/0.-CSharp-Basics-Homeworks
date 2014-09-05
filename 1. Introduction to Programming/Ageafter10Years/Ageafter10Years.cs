using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Ageafter10Years
{
    static void Main()
    {
        Console.WriteLine("Print your birth day in the format dd/mm/yyyy and press enter");
        string a = Console.ReadLine();
        DateTime b = Convert.ToDateTime(a);
        DateTime today = DateTime.Now;
        {
            if (b <= today)
            {
                int age = today.Year - b.Year;
                if (today < b.AddYears(age)) age--;
                int ageplus10 = age + 10;
                Console.WriteLine("Your current age is {0} years. It 10 years you will be {1} years old", age, ageplus10);
            }
            else
            {
                Console.WriteLine("You are not yet born!!!");
            }
        }
    }
}