using System;

class BankAccount
{
    static void Main()
    {
        string FirstName;
        string SecondName;
        string LastName;
        string balance;
        decimal balance1;
        string Bank;
        string IBAN;
        string Card1;
        string Card2;
        string Card3;
        do
        {
            Console.WriteLine("Enter your first name and press enter");
            FirstName = Console.ReadLine();
            if (FirstName.Length < 1) Console.WriteLine("Invalid name, please re-enter and press enter");
        } while (FirstName.Length < 1);
        Console.WriteLine("Enter your second name and press enter");
        SecondName = Console.ReadLine();
        do
        {
            Console.WriteLine("Enter your last name and press enter");
            LastName = Console.ReadLine();
            if (LastName.Length < 1) Console.WriteLine("Invalid name, please re-enter and press enter");
        } while (LastName.Length < 1);

        Console.WriteLine("Enter the available amount of money on your account in BGN");
        balance = Console.ReadLine();
        balance1 = Convert.ToDecimal(balance);
        do
        {
            Console.WriteLine("Enter your bank name and press enter");
            Bank = Console.ReadLine();
            if (Bank.Length < 1) Console.WriteLine("Invalid  bank name, please re-enter and press enter");
        } while (Bank.Length < 1);
        do
        {
            Console.WriteLine("Enter your IBAN and press enter");
            IBAN = Console.ReadLine();
            if (IBAN.Length != 22) Console.WriteLine("Invalid IBAN. Please re-enter your IBAN, which should contain 22 symbols and press enter");
        } while (IBAN.Length != 22);
        do
        {
            Console.WriteLine("Enter your first card number using digits with NO spaces and press enter");
            Card1 = Console.ReadLine();
            if (Card1.Length != 16) Console.WriteLine("Invalid card number. Please re-enter your card number, which should contain only 16 digits, and press enter");
        } while (Card1.Length != 16);
        do
        {
            Console.WriteLine("Enter your second card number using digits with NO spaces and press enter");
            Card2 = Console.ReadLine();
            if (Card2.Length != 16) Console.WriteLine("Invalid card number. Please re-enter your card number, which should contain only 16 digits, and press enter");
        } while (Card2.Length != 16);
        do
        {
            Console.WriteLine("Enter your third card number using digits with NO spaces and press enter");
            Card3 = Console.ReadLine();
            if (Card3.Length != 16) Console.WriteLine("Invalid card number. Please re-enter your card number, which should contain only 16 digits, and press enter");
        } while (Card3.Length != 16);
        Object name = FirstName + " " + SecondName + " " + LastName;
        Console.WriteLine("The client {0} of bank {1} has an account with IBAN {2}, on which he has a balance of BGN {3}. He holds three cards each with the respective number: {4}, {5} and {6}", name, Bank, IBAN, balance1, Card1, Card2, Card3);
    }
}