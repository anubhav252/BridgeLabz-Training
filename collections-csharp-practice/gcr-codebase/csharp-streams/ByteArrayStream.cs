using System;
using System.IO;

class ByteArrayStream
{
    static void Main()
    {
        Console.Write("Enter source image path: ");
        string sourcePath = Console.ReadLine();

        Console.Write("Enter destination image path: ");
        string destinationPath = Console.ReadLine();

        if (!File.Exists(sourcePath))
        {
            Console.WriteLine("Image file not found.");
            return;
        }

        try
        {
            byte[] imageBytes;

            using (FileStream fs = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (MemoryStream ms = new MemoryStream())
            {
                fs.CopyTo(ms);
                imageBytes = ms.ToArray();
            }

            using (MemoryStream ms = new MemoryStream(imageBytes))
            using (FileStream fs = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(fs);
            }

            bool identical =File.ReadAllBytes(sourcePath).Length ==File.ReadAllBytes(destinationPath).Length;

            Console.WriteLine("Image conversion completed.");

            if (identical)
                Console.WriteLine("Verification successful: Files are identical.");
            else
                Console.WriteLine("Verification failed: Files differ.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error: " + ex.Message);
        }
    }
}
