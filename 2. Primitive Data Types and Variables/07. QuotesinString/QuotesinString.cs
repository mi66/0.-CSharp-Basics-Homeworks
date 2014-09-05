using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuotesinString
{
    class QuotesinString
    {
        static void Main()
        {
            string a = @"The ""use"" of quotations causes difficulties.";
            string b = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
