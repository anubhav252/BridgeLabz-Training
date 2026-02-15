using System.IO;

static class FileLogger
{
    private static readonly object _lock = new();

    public static void Log(string fileName, string message)
    {
        lock (_lock)   
        {
            File.AppendAllText(fileName, message + Environment.NewLine);
        }
    }
}
