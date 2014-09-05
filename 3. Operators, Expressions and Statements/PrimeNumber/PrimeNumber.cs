using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class PrimeNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter any number from 1 to 100");
            int a = int.Parse(Console.ReadLine());
            if (a < 1 || a > 100)
            {
                Console.WriteLine("Enter the correct number");
            }
            else
            {
                if (a == 1) { Console.WriteLine("The number is a prime number", a); }
                int i;
                for (i = 2; i < a; i++)
                {
                    int m;
                    m = a % i;
                    if (m == 0)
                    {
                        break;
                    }
                }
                if (i == a) { Console.WriteLine("The number {0} is a prime number", a); }
                else { Console.WriteLine("The number {0} is not a prime number", a); }
            }
        }
    }


//using System;
//using System.Collections.Generic;
//using System.Linq;
    //using System.Text;

//namespace PrimeNUm
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n;
//            string a;
//            int i;
//            int m;
//            Console.WriteLine("Enter number");
//            a = Console.ReadLine();
//            n = Convert.ToInt32(a);
//            
//            if ((n == 1) || (n==-1)) { Console.WriteLine("The number {0} is a prime number",n); }
//            if (n < -1)
//            {
//                for (i = -2; i > n; i--)
//                {
//                    m = n % i;
//                    if (m == 0)
//                    {
//                        break;
//                    }
//                }
//                if (i == n) { Console.WriteLine("The number {0} is a prime number", n); }
//                else { Console.WriteLine("The number {0} is not a prime number", n); }
//            }
//            else
//            {
//                for (i = 2; i < n; i++)
//                {
//                    m = n % i;
//                     if (m == 0)
//                     if (m == 0)
//                     if (m == 0)
//                     if (m == 0)
//                     {
//                         break;
//                     }
//                 }
//                 if (i == n) { Console.WriteLine("The number {0} is a prime number", n); }
//                 else { Console.WriteLine("The number {0} is not a prime number", n); }
//             }
//         }
// 
//     }
// }
