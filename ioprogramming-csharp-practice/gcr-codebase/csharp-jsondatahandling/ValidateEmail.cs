using System;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Program
{
    static void Main()
    {
        string jsonData = File.ReadAllText("user.json");
        string schemaData = File.ReadAllText("userSchema.json");

        JSchema schema = JSchema.Parse(schemaData);
        JObject jsonObject = JObject.Parse(jsonData);

        bool isValid = jsonObject.IsValid(schema, out IList<string> errors);

        if (isValid)
        {
            Console.WriteLine("Email format is correct.");
        }
        else
        {
            Console.WriteLine("JSON is invalid.");
            Console.WriteLine("Errors:");
            foreach (string error in errors)
            {
                Console.WriteLine(error);
            }
        }
    }
}
