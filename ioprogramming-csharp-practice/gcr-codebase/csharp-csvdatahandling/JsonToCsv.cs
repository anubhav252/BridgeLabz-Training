using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

class JsonCsvConverter
{
    static void Main()
    {
        ConvertJsonToCsv("students.json", "students.csv");
        ConvertCsvToJson("students.csv", "students_converted.json");

        Console.WriteLine("JSON CSV conversion completed.");
    }

    // JSON → CSV
    static void ConvertJsonToCsv(string jsonFile, string csvFile)
    {
        string json = File.ReadAllText(jsonFile);

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        List<Student> students =
            JsonSerializer.Deserialize<List<Student>>(json, options);

        List<string> lines = new List<string>();
        lines.Add("Id,Name,Age,Marks");

        foreach (var s in students)
        {
            lines.Add($"{s.Id},{s.Name},{s.Age},{s.Marks}");
        }

        File.WriteAllLines(csvFile, lines);
    }

    // CSV → JSON
    static void ConvertCsvToJson(string csvFile, string jsonFile)
    {
        string[] lines = File.ReadAllLines(csvFile);
        List<Student> students = new List<Student>();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            students.Add(new Student
            {
                Id = int.Parse(data[0]),
                Name = data[1],
                Age = int.Parse(data[2]),
                Marks = int.Parse(data[3])
            });
        }

        string json = JsonSerializer.Serialize(
            students,
            new JsonSerializerOptions { WriteIndented = true }
        );

        File.WriteAllText(jsonFile, json);
    }
}
