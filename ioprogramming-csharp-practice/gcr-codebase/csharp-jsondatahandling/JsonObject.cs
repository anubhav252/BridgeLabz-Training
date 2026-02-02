using System;
using System.Text.Json;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string[] Subjects { get; set; }
}

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            Name = "Rahul Sharma",
            Age = 20,
            Subjects = new string[] { "Mathematics", "Physics", "Computer Science" }
        };

        string json = JsonSerializer.Serialize(
            student,
            new JsonSerializerOptions { WriteIndented = true }
        );

        Console.WriteLine(json);
    }
}
