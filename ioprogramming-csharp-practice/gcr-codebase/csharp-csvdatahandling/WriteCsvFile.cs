using System;
using System.IO;

class WriteCsvFile
{
    static void Main(string[] args)
    {
        string filePath = "employees.csv";

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID,Name,Department,Salary");

                writer.WriteLine("101,Rahul,IT,55000");
                writer.WriteLine("102,Anita,HR,48000");
                writer.WriteLine("103,Karan,Finance,62000");
            }

            Console.WriteLine("Employee data written successfully to employees.csv");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing CSV file: " + ex.Message);
        }
    }
}
