using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        char c = '\u00A9';
        //char c = (char)169;
        Console.OutputEncoding = Encoding.UTF8;  //change the console character encoding to UTF-8
        Console.WriteLine("   " + c + "   ");
        Console.WriteLine("  " + c + " " + c + "  ");
        Console.WriteLine(" " + c + "   " + c + " ");
        Console.WriteLine(c + " " + c + " " + c + " " + c);
    }
}