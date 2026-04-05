using System;
using System.IO;

class InputToFile
{
    static void Main()
    {
        string filePath = "UserData.txt";

        try
        {
            using (StreamReader input = new StreamReader(Console.OpenStandardInput()))
            {
                Console.Write("Enter your name: ");
                string name = input.ReadLine();

                Console.Write("Enter your age: ");
                string age = input.ReadLine();

                Console.Write("Enter your favorite programming language: ");
                string language = input.ReadLine();

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("Name: " + name);
                    writer.WriteLine("Age: " + age);
                    writer.WriteLine("Favorite Language: " + language);
                    writer.WriteLine("-----------------------------");
                }
            }

            Console.WriteLine("Data saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
