using System;

    class ComparingFloats
    {
        static void Main()
        {
            string number1;
            string number2;
            double number11;
            double number22;
            Console.WriteLine("Enter the first number and press enter");
            number1 = Console.ReadLine();
            number11 = Convert.ToDouble(number1);
            Console.WriteLine("Enter the second number and press enter");
            number2 = Console.ReadLine();
            number22 = Convert.ToDouble(number2);
            if (number22 - number11 >= 0.000001 || number22 - number11 <= -0.000001) Console.WriteLine("The numbers are not the same with precision eps = 0.000001");
            if (number22 - number11 < 0.000001 && number22 - number11 > -0.000001) Console.WriteLine("The numbers are the same with precision eps = 0.000001");
        }
    }