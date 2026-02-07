using System;
using System.IO;
using System.Collections.Generic;

class Student
{
    public string Id;
    public string Name;
    public string Age;
    public string Marks;
    public string Grade;
}

class MergeCSVFiles
{
    static void Main()
    {
        string file1 = "student1.csv";
        string file2 = "student2.csv";
        string outputFile = "students_merged.csv";

        if (!File.Exists(file1) || !File.Exists(file2))
        {
            Console.WriteLine("One or both CSV files not found.");
            return;
        }

        Dictionary<string, Student> studentMap =
            new Dictionary<string, Student>();

        
        string[] lines1 = File.ReadAllLines(file1);
        for (int i = 1; i < lines1.Length; i++)
        {
            string[] data = lines1[i].Split(',');

            studentMap[data[0]] = new Student
            {
                Id = data[0],
                Name = data[1],
                Age = data[2]
            };
        }

        string[] lines2 = File.ReadAllLines(file2);
        for (int i = 1; i < lines2.Length; i++)
        {
            string[] data = lines2[i].Split(',');

            if (studentMap.ContainsKey(data[0]))
            {
                studentMap[data[0]].Marks = data[1];
                studentMap[data[0]].Grade = data[2];
            }
        }

        List<string> output = new List<string>();
        output.Add("ID,Name,Age,Marks,Grade");

        foreach (var student in studentMap.Values)
        {
            output.Add(
                $"{student.Id},{student.Name},{student.Age},{student.Marks},{student.Grade}"
            );
        }

        File.WriteAllLines(outputFile, output);

        Console.WriteLine("CSV files merged successfully.");
    }
}
