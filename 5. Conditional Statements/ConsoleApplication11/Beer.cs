using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;

namespace Beer
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime beer;
            CultureInfo enUS = new CultureInfo("en-US");   // way of representing the date and time
            Console.WriteLine("Enter hour");
            string beer1 = Console.ReadLine();
            
           DateTime Start = DateTime.Parse("1:00 PM");     // parse Date Time
           DateTime End = DateTime.Parse("3:00 AM");
           if (DateTime.TryParseExact(beer1, "h:mm tt", enUS, DateTimeStyles.None, out beer))  // convert date using specified format
           {
               if (beer > Start || beer < End)
               {
                   Console.WriteLine("beer time");
               }
               else
               {
                   Console.WriteLine("rakia time");
               }
           }
           else
           {
               Console.WriteLine("invalid time");
           }
            
        }
    }
}
