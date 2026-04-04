using System;
using System.IO;

class CountOccurence
{
    static void Main()
    {
        StreamReader sr = new StreamReader("input.txt");
        string word = Console.ReadLine();
        string line;
        int count = 0;

        while ((line = sr.ReadLine()) != null)
        {
            string[] parts = line.Split(' ');
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] == word)
                    count++;
            }
        }

        sr.Close();
        Console.WriteLine(count);
    }
}
