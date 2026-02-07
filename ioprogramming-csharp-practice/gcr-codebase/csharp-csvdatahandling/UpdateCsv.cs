using System;
using System.IO;
using System.Collections.Generic;

class UpdateEmployeeSalary
{
    static void Main()
    {
        string inputFile = "employees.csv";
        string outputFile = "employees_updated.csv";

        if (!File.Exists(inputFile))
        {
            Console.WriteLine("Input CSV file not found.");
            return;
        }

        List<string> updatedLines = new List<string>();

        try
        {
            string[] lines = File.ReadAllLines(inputFile);

            updatedLines.Add(lines[0]); 

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                string department = data[2];
                double salary = double.Parse(data[3]);

                if (department.Equals("IT", StringComparison.OrdinalIgnoreCase))
                {
                    salary = salary * 1.10; 
                }

                data[3] = salary.ToString("F2");

                updatedLines.Add(string.Join(",", data));
            }

            File.WriteAllLines(outputFile, updatedLines);

            Console.WriteLine("Updated CSV file created successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error processing CSV file: " + ex.Message);
        }
    }
}
