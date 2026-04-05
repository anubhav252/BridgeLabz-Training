using System;
using System.IO;

class CountRowInCsv
{
    static void Main()
    {
        string filePath = "students.csv";
        int count = 0;

        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found.");
            return;
        }

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                bool isHeader = true;
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }

                    if (!string.IsNullOrWhiteSpace(line))
                        count++;
                }
            }

            Console.WriteLine("Total records : " + count);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading CSV file: " + ex.Message);
        }
    }
}
