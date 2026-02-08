using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class FindRepeatingWords
{
    static void Main()
    {
        string input = "This is is a repeated repeated word test.";

        string pattern = @"\b(\w+)\s+\1\b";

        MatchCollection matches =Regex.Matches(input, pattern, RegexOptions.IgnoreCase);

        HashSet<string> repeatedWords = new HashSet<string>();

        foreach (Match match in matches)
        {
            repeatedWords.Add(match.Groups[1].Value);
        }

        foreach (string word in repeatedWords)
        {
            Console.WriteLine(word);
        }
    }
}
