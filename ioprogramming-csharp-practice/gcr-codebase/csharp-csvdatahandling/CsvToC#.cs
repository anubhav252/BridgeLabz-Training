using System;
using System.IO;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

class CsvToCsharp
{
    static void Main()
    {
        string filePath = "students.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found.");
            return;
        }

        List<Student> students = new List<Student>();

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                Student s = new Student
                {
                    Id = int.Parse(data[0]),
                    Name = data[1],
                    Age = int.Parse(data[2]),
                    Marks = int.Parse(data[3])
                };

                students.Add(s);
            }

            Console.WriteLine("Student Records:\n");

            foreach (Student s in students)
            {
                Console.WriteLine(
                    $"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}, Marks: {s.Marks}"
                );
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading CSV file: " + ex.Message);
        }
    }
}
