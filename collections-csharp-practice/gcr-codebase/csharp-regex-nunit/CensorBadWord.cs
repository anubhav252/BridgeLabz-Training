using System;
using System.Text.RegularExpressions;

class CensorBadWords
{
    static void Main()
    {
        string input ="This is a damn bad example with some stupid words.";

        string[] badWords = { "damn", "stupid" };

        string pattern = @"\b(" + string.Join("|", badWords) + @")\b";

        string output = Regex.Replace(input,pattern,"****",RegexOptions.IgnoreCase);

        Console.WriteLine(output);
    }
}
