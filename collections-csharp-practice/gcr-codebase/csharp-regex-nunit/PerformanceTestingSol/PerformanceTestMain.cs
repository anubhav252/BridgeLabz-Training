using System.Threading;

public class PerformanceUtils
{
    public string LongRunningTask()
    {
        Thread.Sleep(3000); 
        return "Completed";
    }
}
