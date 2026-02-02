using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Text.Json.Serialization;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("people.json");

        var options = new JsonSerializerOptions{PropertyNameCaseInsensitive = true};

        List<Person> people =JsonSerializer.Deserialize<List<Person>>(json, options);

        foreach (var p in people)
        {
            if(p.Age>25)
                Console.WriteLine($"{p.Name} - {p.Age}");
        }
    }
}
