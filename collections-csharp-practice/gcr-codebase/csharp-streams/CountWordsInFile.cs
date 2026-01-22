using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class WordFrequencyCounter
{
    static void Main()
    {
        Console.Write("Enter file path: ");
        string filePath = Console.ReadLine();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = Regex.Split(line, @"\W+");

                    foreach (string word in words)
                    {
                        if (string.IsNullOrWhiteSpace(word))
                            continue;

                        if (wordCount.ContainsKey(word))
                            wordCount[word]++;
                        else
                            wordCount[word] = 1;
                    }
                }
            }

            var topWords = wordCount
                .OrderByDescending(w => w.Value)
                .Take(5);

            Console.WriteLine("\nTop 5 Most Frequent Words:\n");

            foreach (var item in topWords)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
