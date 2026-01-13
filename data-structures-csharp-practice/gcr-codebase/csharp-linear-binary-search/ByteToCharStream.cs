using System;
using System.IO;

class Program
{
    static void Main()
    {
        FileStream fs = new FileStream("input.txt", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        string data;

        while ((data = sr.ReadLine()) != null)
            Console.WriteLine(data);

        sr.Close();
        fs.Close();
    }
}
