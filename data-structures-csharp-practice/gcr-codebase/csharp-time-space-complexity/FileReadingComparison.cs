using System;
using System.IO;
using System.Text;

class FileReadingComparison
{
    static void ReadUsingStreamReader(string path)
    {
        using (StreamReader reader = new StreamReader(path))
        {
            while (reader.Read() != -1) { }
        }
    }

    static void ReadUsingFileStream(string path)
    {
        byte[] buffer = new byte[8192];

        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
    }

    static void Main()
    {
        string filePath = "file.txt";

        DateTime start, end;

        start = DateTime.Now;
        ReadUsingStreamReader(filePath);
        end = DateTime.Now;
        Console.WriteLine("StreamReader Time: " + (end - start).TotalMilliseconds + " ms");

        start = DateTime.Now;
        ReadUsingFileStream(filePath);
        end = DateTime.Now;
        Console.WriteLine("FileStream Time: " + (end - start).TotalMilliseconds + " ms");
    }
}
