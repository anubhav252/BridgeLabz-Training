using System;
using System.Text.RegularExpressions;

class NormalizeSpaces
{
    static void Main()
    {
        string input = "This   is   an   example    with   multiple   spaces.";

        string output = Regex.Replace(input, @"\s+", " ");

        Console.WriteLine(output);
    }
}
