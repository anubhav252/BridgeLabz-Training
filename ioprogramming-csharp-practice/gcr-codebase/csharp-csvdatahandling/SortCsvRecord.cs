using System;
using System.IO;
using System.Collections.Generic;

class Employee
{
    public string Id;
    public string Name;
    public string Department;
    public double Salary;
}

class SortCsvRecords
{
    static void Main()
    {
        string filePath = "employees.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found.");
            return;
        }

        List<Employee> employees = new List<Employee>();

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                employees.Add(new Employee
                {
                    Id = data[0],
                    Name = data[1],
                    Department = data[2],
                    Salary = double.Parse(data[3])
                });
            }

            employees.Sort((a, b) => b.Salary.CompareTo(a.Salary));

            Console.WriteLine("Top 5 Highest-Paid Employees:\n");

            for (int i = 0; i < 5 && i < employees.Count; i++)
            {
                Employee e = employees[i];
                Console.WriteLine(
                    $"{e.Id} | {e.Name} | {e.Department} | {e.Salary}"
                );
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error processing CSV file: " + ex.Message);
        }
    }
}
