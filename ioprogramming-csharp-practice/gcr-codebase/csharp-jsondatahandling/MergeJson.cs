using System;
using System.Collections.Generic;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string json1 = @"{ ""name"": ""Rahul"", ""age"": 22 }";
        string json2 = @"{ ""email"": ""rahul@gmail.com"", ""city"": ""Delhi"" }";

        Dictionary<string, object> merged = new Dictionary<string, object>();

        MergeJson(json1, merged);
        MergeJson(json2, merged);

        string result = JsonSerializer.Serialize(merged, new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine(result);
    }

    static void MergeJson(string json, Dictionary<string, object> target)
    {
        using JsonDocument doc = JsonDocument.Parse(json);

        foreach (var property in doc.RootElement.EnumerateObject())
        {
            target[property.Name] = property.Value.Deserialize<object>();
        }
    }
}
