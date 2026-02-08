using System;
using System.Text.RegularExpressions;

class HexColorValidator
{
    static void Main()
    {
        Console.Write("Enter hex color code: ");
        string input = Console.ReadLine();

        string pattern = @"^#[0-9A-Fa-f]{6}$";

        if (Regex.IsMatch(input, pattern))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}
