using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("data.json");

        using (JsonDocument doc = JsonDocument.Parse(json))
        {
            JsonElement root = doc.RootElement;

            foreach (JsonProperty property in root.EnumerateObject())
            {
                Console.WriteLine(property.Name + " : " + property.Value);
            }
        }
    }
}
