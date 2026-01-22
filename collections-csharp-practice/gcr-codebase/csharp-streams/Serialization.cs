using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static string filePath = "employees.json";

    static void Main()
    {
        try
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter number of employees: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Employee emp = new Employee();

                Console.Write("ID: ");
                emp.Id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                emp.Name = Console.ReadLine();

                Console.Write("Department: ");
                emp.Department = Console.ReadLine();

                Console.Write("Salary: ");
                emp.Salary = double.Parse(Console.ReadLine());

                employees.Add(emp);
                Console.WriteLine();
            }

            string jsonData = JsonSerializer.Serialize(employees);
            File.WriteAllText(filePath, jsonData);

            Console.WriteLine("Employees saved successfully.\n");

            string readData = File.ReadAllText(filePath);
            List<Employee> loadedEmployees =JsonSerializer.Deserialize<List<Employee>>(readData);

            Console.WriteLine("Retrieved Employee Data:\n");

            foreach (Employee e in loadedEmployees)
            {
                Console.WriteLine($"ID: {e.Id}, Name: {e.Name}, Dept: {e.Department}, Salary: {e.Salary}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
