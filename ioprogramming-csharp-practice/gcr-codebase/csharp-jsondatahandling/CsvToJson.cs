using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string csvPath = "students.csv";
        string jsonPath = "students.json";

        List<Dictionary<string, string>> records =new List<Dictionary<string, string>>();

        string[] lines = File.ReadAllLines(csvPath);

        string[] headers = lines[0].Split(',');

        for (int i = 1; i < lines.Length; i++)
        {
            string[] values = lines[i].Split(',');

            Dictionary<string, string> record =new Dictionary<string, string>();

            for (int j = 0; j < headers.Length; j++)
            {
                record[headers[j]] = values[j];
            }

            records.Add(record);
        }

        string json = JsonSerializer.Serialize(records,new JsonSerializerOptions { WriteIndented = true });

        File.WriteAllText(jsonPath, json);

        Console.WriteLine("CSV converted to JSON successfully.");
    }
}
