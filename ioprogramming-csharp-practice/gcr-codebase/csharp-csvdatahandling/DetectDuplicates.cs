using System;
using System.IO;
using System.Collections.Generic;

class DetectDuplicate
{
    static void Main()
    {
        string filePath = "employees.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found.");
            return;
        }

        HashSet<string> seenIds = new HashSet<string>();
        List<string> duplicates = new List<string>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string header = reader.ReadLine(); 
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    string id = data[0];

                    if (seenIds.Contains(id))
                    {
                        duplicates.Add(line);
                    }
                    else
                    {
                        seenIds.Add(id);
                    }
                }
            }

            if (duplicates.Count > 0)
            {
                Console.WriteLine("Duplicate Records Found:\n");
                foreach (string record in duplicates)
                {
                    Console.WriteLine(record);
                }
            }
            else
            {
                Console.WriteLine("No duplicate records found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error processing CSV file: " + ex.Message);
        }
    }
}
