using System;
using System.IO;

class ReadWriteTextFile
{
    static void Main(string[]  args)
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
            using (FileStream readStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream writeStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = readStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    writeStream.Write(buffer, 0, bytesRead);
                }
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File operation failed: " + ex.Message);
        }
    }
}
