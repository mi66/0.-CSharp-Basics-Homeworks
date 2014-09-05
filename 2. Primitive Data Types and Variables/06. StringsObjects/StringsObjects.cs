using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class StringsObjects
{
    static void Main()
    {
        string a = "Hello";
        string b = "World";
        object c = a + " " + b;
        string d = (string)c;
        Console.WriteLine(d);
    }
}