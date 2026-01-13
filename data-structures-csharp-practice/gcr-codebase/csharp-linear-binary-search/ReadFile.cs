using System;
using System.IO;

class ReadFile
{
    static void Main()
    {
        StreamReader sr = new StreamReader("input.txt");
        string line;

        while ((line = sr.ReadLine()) != null)
            Console.WriteLine(line);

        sr.Close();
    }
}
