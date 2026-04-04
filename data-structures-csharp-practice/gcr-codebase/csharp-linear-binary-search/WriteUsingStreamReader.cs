using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        StreamWriter sw = new StreamWriter("output.txt");
        string input;

        while (true)
        {
            input = Console.ReadLine();
            if (input == "exit")
                break;

            sw.WriteLine(input);
        }

        sw.Close();
    }
}
