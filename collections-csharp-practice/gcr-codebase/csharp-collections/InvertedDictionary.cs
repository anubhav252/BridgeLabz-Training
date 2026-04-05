using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> input =new Dictionary<string, int>(){{ "A", 1 },{ "B", 2 },{ "C", 1 }};

        // Inverted dictionary
        Dictionary<int, List<string>> inverted =new Dictionary<int, List<string>>();

        foreach (KeyValuePair<string, int> pair in input)
        {
            int value = pair.Value;
            string key = pair.Key;
            if (!inverted.ContainsKey(value))
            {
                inverted[value] = new List<string>();
            }
            inverted[value].Add(key);
        }
        foreach (var entry in inverted)
        {
            Console.Write(entry.Key + " = [");

            for (int i = 0; i < entry.Value.Count; i++)
            {
                Console.Write(entry.Value[i]);

                if (i < entry.Value.Count - 1)
                    Console.Write(", ");
            }

            Console.WriteLine("]");
        }
    }
}
