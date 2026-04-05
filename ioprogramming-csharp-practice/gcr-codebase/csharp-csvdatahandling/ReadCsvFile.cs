using System;
using System.IO;

class StudentCSVReader
{
    static void Main()
    {
        string filePath = "students.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found.");
            return;
        }

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] data = line.Split(',');

                    int id = int.Parse(data[0]);
                    string name = data[1];
                    int age = int.Parse(data[2]);
                    int marks = int.Parse(data[3]);

                    Console.WriteLine("---------------");
                    Console.WriteLine("ID    : " + id);
                    Console.WriteLine("Name  : " + name);
                    Console.WriteLine("Age   : " + age);
                    Console.WriteLine("Marks : " + marks);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading CSV file: " + ex.Message);
        }
    }
}
