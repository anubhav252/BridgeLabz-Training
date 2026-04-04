using System;

class SearchWord
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] sentences = new string[n];

        for (int i = 0; i < n; i++)
            sentences[i] = Console.ReadLine();

        string word = Console.ReadLine();
        int index = -1;

        for (int i = 0; i < n; i++)
        {
            if (sentences[i].Contains(word))
            {
                index = i;
                break;
            }
        }

        if (index != -1)
            Console.WriteLine(sentences[index]);
        else
            Console.WriteLine("Word not found");
    }
}
