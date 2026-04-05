using System;
using System.Text.RegularExpressions;

class ExtractCurrency
{
    static void Main()
    {
        string text ="The price is $45.99, and the discount is $ 10.50.";

        string pattern = @"\$?\s?\d+\.\d{2}";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            string value = match.Value.Trim();

            if (value.StartsWith("$ "))
                value = value.Substring(2);
            else if (value.StartsWith("$"))
                value = value;

            Console.WriteLine(value);
        }
    }
}
