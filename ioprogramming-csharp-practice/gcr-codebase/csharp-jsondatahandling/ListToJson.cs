using System;
using System.Collections.Generic;
using System.Text.Json;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Rahul", Age = 20 },
            new Student { Id = 2, Name = "Anita", Age = 21 },
            new Student { Id = 3, Name = "Kiran", Age = 19 }
        };

        string jsonArray = JsonSerializer.Serialize(students,new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine(jsonArray);
    }
}
