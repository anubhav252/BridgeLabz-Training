using System;
using System.Text.RegularExpressions;

class CreditCardValidator
{
    static void Main()
    {
        Console.Write("Enter credit card number: ");
        string cardNumber = Console.ReadLine();

        string pattern = @"^(4\d{15}|5\d{15})$";

        if (Regex.IsMatch(cardNumber, pattern))
        {
            if (cardNumber.StartsWith("4"))
                Console.WriteLine("Valid Visa Card");
            else
                Console.WriteLine("Valid MasterCard");
        }
        else
        {
            Console.WriteLine("Invalid Credit Card Number");
        }
    }
}
