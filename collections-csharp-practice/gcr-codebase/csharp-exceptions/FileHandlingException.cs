using System;
using System.IO;

class FileHandlingException
{
    static void Main()
    {
        string fileName = "info.txt";

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string firstLine = reader.ReadLine();
                Console.WriteLine(firstLine);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error : reading file");
        }
    }
}
