using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string www ="";
            string www1="";
            string www2="";
            double num;
            string a = "Zero";
            string b = "One";
            string c = "Two";
            string d = "Three";
            string e = "Four";
            string f = "Five";
            string g = "Six";
            string h = "Seven";
            string i = "Eight";
            string j = "Nine";
            string k = "Ten";
            string l = "Eleven";
            string m = "Twelve";
            string n = "Thirteen";
            string o = "Fourteen";
            string p = "Fifteen";
            string q = "Sixteen";
            string r = "Seventeen";
            string s = "Eighteen";
            string t = "Nineteen";
            string u = "Twenty";
            string v = "Thirty";
            string w = "Forty";
            string x = "Fifty";
            string y = "Sixty";
            string z = "Seventy";
            string ab = "Eighty";
            string ac = "Ninety";
            string zz = "Hundred";
            

           Console.WriteLine("Enter number and press enter");
           num =double.Parse(Console.ReadLine());
           if (num < 0 || num > 999 || num % 1 != 0)
               do
               {
                   Console.WriteLine("Invalid number. Please enter an integer between 0 and 999 and press enter");
                   num = double.Parse(Console.ReadLine());
               }
               while (num < 0 || num > 999 || num % 1 != 0);
           if (num >= 0 && num <= 19)
           {
               if (num == 0) www=a;
               if (num == 1) www=b;
               if (num == 2) www=c;
               if (num == 3) www=d;
               if (num == 4) www=e;
               if (num == 5) www=f;
               if (num == 6) www=g;
               if (num == 7) www=h;
               if (num == 8) www=i;
               if (num == 9) www=j;
               if (num == 10) www=k;
               if (num == 11) www=l;
               if (num == 12) www=m;
               if (num == 13) www=n;
               if (num == 14) www=o;
               if (num == 15) www=p;
               if (num == 16) www=q;
               if (num == 17) www=r;
               if (num == 18) www=s;
               if (num == 19) www=t;
               Console.WriteLine(www);
           }

           if (num >= 20 && num <= 99)
           {
               double num1 = num / 10;
               if (Math.Floor(num1) == 2) www1 = u;
               if (Math.Floor(num1) == 3) www1 = v;
               if (Math.Floor(num1) == 4) www1 = w;
               if (Math.Floor(num1) == 5) www1 = x;
               if (Math.Floor(num1) == 6) www1 = y;
               if (Math.Floor(num1) == 7) www1 = z;
               if (Math.Floor(num1) == 8) www1 = ab;
               if (Math.Floor(num1) == 9) www1 = ac;
               if (num % 10 == 0) www = "";
               if (num % 10 == 1) www = b;
               if (num % 10 == 2) www = c;
               if (num % 10 == 3) www = d;
               if (num % 10 == 4) www = e;
               if (num % 10 == 5) www = f;
               if (num % 10 == 6) www = g;
               if (num % 10 == 7) www = h;
               if (num % 10 == 8) www = i;
               if (num % 10 == 9) www = j;
               Console.WriteLine("{0} {1}", www1, www);
           }
           if (num >= 100 && num <= 999)
           {
               string and = "and";
               double num1 = num % 100;
               double num2 = num / 100;
               if (num1 == 0) and="";
               if (Math.Floor(num2) == 1) www2 = b;
               if (Math.Floor(num2) == 2) www2 = c;
               if (Math.Floor(num2) == 3) www2 = d;
               if (Math.Floor(num2) == 4) www2 = e;
               if (Math.Floor(num2) == 5) www2 = f;
               if (Math.Floor(num2) == 6) www2 = g;
               if (Math.Floor(num2) == 7) www2 = h;
               if (Math.Floor(num2) == 8) www2 = i;
               if (Math.Floor(num2) == 9) www2 = j;
               if (num1 > 0 && num1 <= 19)
                {
               
               if (num1 == 1) www=b;
               if (num1 == 2) www=c;
               if (num1 == 3) www=d;
               if (num1 == 4) www=e;
               if (num1 == 5) www=f;
               if (num1 == 6) www=g;
               if (num1 == 7) www=h;
               if (num1 == 8) www=i;
               if (num1 == 9) www=j;
               if (num1 == 10) www=k;
               if (num1 == 11) www=l;
               if (num1 == 12) www=m;
               if (num1 == 13) www=n;
               if (num1 == 14) www=o;
               if (num1 == 15) www=p;
               if (num1 == 16) www=q;
               if (num1 == 17) www=r;
               if (num1 == 18) www=s;
               if (num1 == 19) www=t;
               Console.WriteLine("{0} {1} {2} {3}", www2, zz, and, www);
               }

               if (num1 >= 20 && num1 <= 99)
               {
                   double num3 = num1 / 10;
                   if (Math.Floor(num3) == 2) www1 = u;
                   if (Math.Floor(num3) == 3) www1 = v;
                   if (Math.Floor(num3) == 4) www1 = w;
                   if (Math.Floor(num3) == 5) www1 = x;
                   if (Math.Floor(num3) == 6) www1 = y;
                   if (Math.Floor(num3) == 7) www1 = z;
                   if (Math.Floor(num3) == 8) www1 = ab;
                   if (Math.Floor(num3) == 9) www1 = ac;
                   if (num1 % 10 == 0) www = "";
                   if (num1 % 10 == 1) www = b;
                   if (num1 % 10 == 2) www = c;
                   if (num1 % 10 == 3) www = d;
                   if (num1 % 10 == 4) www = e;
                   if (num1 % 10 == 5) www = f;
                   if (num1 % 10 == 6) www = g;
                   if (num1 % 10 == 7) www = h;
                   if (num1 % 10 == 8) www = i;
                   if (num1 % 10 == 9) www = j;
                   Console.WriteLine("{0} {1} {2} {3} {4}", www2, zz, and, www1, www);
               }
               if (num1 == 0) { Console.WriteLine("{0} {1} {2} {3} {4}", www2, zz, and, www1, www); }
               
           }
        }
    }
}
