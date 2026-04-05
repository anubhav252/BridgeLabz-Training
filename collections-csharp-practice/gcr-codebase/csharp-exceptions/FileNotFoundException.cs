using System;
using System.IO;

class FileNotFoundException
{
    static void Main()
    {
        string fileName = "data.txt";

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("File not found!");
        }
    }
}
