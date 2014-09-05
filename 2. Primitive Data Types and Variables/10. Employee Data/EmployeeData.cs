using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class EmployeeData
{
    static void Main()
    {
        int Age;
        string Gender;
        long ID;
        int UEN;
        Console.WriteLine("Print your first name");
        string FN = Console.ReadLine();
        Console.WriteLine("Print your last name");
        string LN = Console.ReadLine();
        Console.WriteLine("Print your age");
        Age = int.Parse(Console.ReadLine());
        while (Age < 0 || Age > 100)
        {
            Console.WriteLine("You have entered invalid age.\nPrint your age.");
            Age = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Print your gender (m/f)");
        Gender = Console.ReadLine();
        while (Gender != "m" && Gender != "f")
        {
            Console.WriteLine("You have entered invalid gender.\nPrint your gender.");
            Gender = Console.ReadLine();
        }
        Console.WriteLine("Print your ID number");
        ID = long.Parse(Console.ReadLine());
        while (ID < 1000000000 || ID > 9999999999)
        {
            Console.WriteLine("You have entered invalid ID.\nEnter your ID.");
            ID = long.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter your unique employee number");
        UEN = int.Parse(Console.ReadLine());
        while (UEN < 27560000 || UEN > 27569999)
        {
            Console.WriteLine("You have entered invalid employee number.\nPrint your unique employee number.");
            UEN = int.Parse(Console.ReadLine());
        }

    }
}