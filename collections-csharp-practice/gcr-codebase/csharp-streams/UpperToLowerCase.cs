using System;
using System.IO;
using System.Text;

class UpperToLowerCase
{
    static void Main()
    {
        Console.Write("Enter source file path: ");
        string sourcePath = Console.ReadLine();

        Console.Write("Enter destination file path: ");
        string destinationPath = Console.ReadLine();

        if (!File.Exists(sourcePath))
        {
            Console.WriteLine("Source file not found.");
            return;
        }

        try
        {
            using (FileStream readFs = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream writeFs = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedRead = new BufferedStream(readFs))
            using (BufferedStream bufferedWrite = new BufferedStream(writeFs))
            using (StreamReader reader = new StreamReader(bufferedRead, Encoding.UTF8))
            using (StreamWriter writer = new StreamWriter(bufferedWrite, Encoding.UTF8))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }

            Console.WriteLine("File conversion completed successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
    }
}
