using System;
using System.IO;
using System.Collections.Generic;

class ReadLargeCsv
{
    static void Main()
    {
        string filePath = "largefile.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found.");
            return;
        }

        int batchSize = 100;
        int totalCount = 0;
        List<string> batch = new List<string>(batchSize);

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                reader.ReadLine();

                while ((line = reader.ReadLine()) != null)
                {
                    batch.Add(line);

                    if (batch.Count == batchSize)
                    {
                        totalCount += batch.Count;
                        Console.WriteLine($"Processed records: {totalCount}");
                        batch.Clear();
                    }
                }
                if (batch.Count > 0)
                {
                    totalCount += batch.Count;
                    Console.WriteLine($"Processed records: {totalCount}");
                }
            }

            Console.WriteLine("\nFinished processing CSV file.");
            Console.WriteLine($"Total records processed: {totalCount}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading CSV file: " + ex.Message);
        }
    }
}
