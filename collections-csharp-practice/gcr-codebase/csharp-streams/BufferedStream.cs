using System;
using System.Diagnostics;
using System.IO;

class BufferStream
{
    static void Main()
    {
        Console.Write("Enter source file path: ");
        string source = Console.ReadLine();

        Console.Write("Enter destination path : ");
        string normalDest = Console.ReadLine();

        Console.Write("Enter destination path buffered stream : ");
        string bufferedDest = Console.ReadLine();

        if (!File.Exists(source))
        {
            Console.WriteLine("Source file not found.");
            return;
        }

        byte[] buffer = new byte[4096];

        Stopwatch watch = new Stopwatch();

        try
        {
            watch.Start();
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(normalDest, FileMode.Create, FileAccess.Write))
            {
                int bytes;
                while ((bytes = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsWrite.Write(buffer, 0, bytes);
                }
            }
            watch.Stop();
            Console.WriteLine("Normal FileStream Time: " + watch.ElapsedMilliseconds + " ms");

            watch.Reset();

            watch.Start();
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(bufferedDest, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedRead = new BufferedStream(fsRead, 4096))
            using (BufferedStream bufferedWrite = new BufferedStream(fsWrite, 4096))
            {
                int bytes;
                while ((bytes = bufferedRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bufferedWrite.Write(buffer, 0, bytes);
                }
            }
            watch.Stop();
            Console.WriteLine("BufferedStream Time: " + watch.ElapsedMilliseconds + " ms");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File operation error: " + ex.Message);
        }
    }
}
