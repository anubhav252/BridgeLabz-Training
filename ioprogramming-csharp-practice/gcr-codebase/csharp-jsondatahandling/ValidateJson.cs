using System;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Program
{
    static void Main()
    {
        string jsonData = File.ReadAllText("student.json");
        string schemaData = File.ReadAllText("studentSchema.json");

        JSchema schema = JSchema.Parse(schemaData);
        JObject jsonObject = JObject.Parse(jsonData);

        bool isValid = jsonObject.IsValid(schema, out IList<string> errors);

        if (isValid)
        {
            Console.WriteLine("JSON is valid.");
        }
        else
        {
            Console.WriteLine("JSON is invalid.");
            Console.WriteLine("Errors:");
            foreach (var error in errors)
            {
                Console.WriteLine(error);
            }
        }
    }
}
