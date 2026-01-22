using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;

class PipedStreamDemo
{
    static void Main()
    {
        try
        {
            using (AnonymousPipeServerStream server =new AnonymousPipeServerStream(PipeDirection.Out,HandleInheritability.Inheritable))

            using (AnonymousPipeClientStream client =new AnonymousPipeClientStream(PipeDirection.In,server.GetClientHandleAsString()))
            {
                Thread writerThread = new Thread(() => Writer(server));
                Thread readerThread = new Thread(() => Reader(client));

                readerThread.Start();
                writerThread.Start();

                writerThread.Join();
                readerThread.Join();
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Pipe error: " + ex.Message);
        }
    }

    static void Writer(Stream stream)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            {
                writer.AutoFlush = true;

                for (int i = 1; i <= 5; i++)
                {
                    writer.WriteLine("Message " + i);
                    Thread.Sleep(500);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Writer error: " + ex.Message);
        }
    }

    static void Reader(Stream stream)
    {
        try
        {
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine("Received: " + line);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Reader error: " + ex.Message);
        }
    }
}
