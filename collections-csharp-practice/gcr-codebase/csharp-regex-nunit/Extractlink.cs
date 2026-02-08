using System;
using System.Text.RegularExpressions;

class ExtractLinks
{
    static void Main()
    {
        string text ="Visit https://www.google.com and http://example.org for more info.";

        string pattern = @"\bhttps?:\/\/[^\s,]+";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
