using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = "Hello world, hello Java!";
        text = text.ToLower();
        char[] separators = {' ', ',', '.', '!', '?', ';', ':', '"', '\'', '(', ')'};

        string[] words = text.Split(separators,StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> frequency =new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (frequency.ContainsKey(word))
            {
                frequency[word]++;
            }
            else
            {
                frequency[word] = 1;
            }
        }

        Console.WriteLine("Word Frequency:");

        foreach (var pair in frequency)
        {
            Console.WriteLine(pair.Key + " : " + pair.Value);
        }
    }
}
