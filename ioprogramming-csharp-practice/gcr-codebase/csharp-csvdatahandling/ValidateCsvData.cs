using System;
using System.IO;
using System.Text.RegularExpressions;

class ValidateCsvData
{
    static void Main()
    {
        string filePath = "user.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("CSV file not found.");
            return;
        }

        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        string phonePattern = @"^\d{10}$";

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("Invalid Records:\n");

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                string name = data[0];
                string email = data[1];
                string phone = data[2];

                bool emailValid = Regex.IsMatch(email, emailPattern);
                bool phoneValid = Regex.IsMatch(phone, phonePattern);

                if (!emailValid || !phoneValid)
                {
                    Console.WriteLine("Row " + (i + 1) + ": " + lines[i]);

                    if (!emailValid)
                        Console.WriteLine("Invalid Email");

                    if (!phoneValid)
                        Console.WriteLine("Invalid Phone Number");

                    Console.WriteLine();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error processing CSV file: " + ex.Message);
        }
    }
}
