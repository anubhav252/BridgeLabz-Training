using System;
using System.Text.RegularExpressions;
class ValidatePlateNumber
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter plate number : ");
        string number=Console.ReadLine();
        string pattern= @"^[A-Z]{2}[0-9]{4}$";
        if (Regex.IsMatch(number, pattern))
        {
            System.Console.WriteLine("valid");
        }
        else
        {
            System.Console.WriteLine("invalid");
        }
    }
}