using System;
using System.Text.RegularExpressions;

class ValidateSSN
{
    static void Main()
    {
        string text = "My SSN is 123-45-6789.";

        string pattern = @"\b\d{3}-\d{2}-\d{4}\b";

        Match match = Regex.Match(text, pattern);

        if (match.Success)
        {
            Console.WriteLine($"\"{match.Value}\" is valid");
        }
        else
        {
            Console.WriteLine("Invalid SSN");
        }
    }
}
