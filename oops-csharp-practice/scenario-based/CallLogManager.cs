using System;
internal class CallLog
{
    public string PhoneNumber ;
    public string Message ;
    public DateTime TimeStamp;

    public CallLog(string phoneNumber, string message, DateTime timeStamp)
    {
        PhoneNumber = phoneNumber;
        Message = message;
        TimeStamp = timeStamp;
    }

    public override string ToString()
    {
        return PhoneNumber + " | " + Message + " | " + TimeStamp;
    }
}

   
internal class CallLogManager
{
    private CallLog[] logs;
    private int count;

    public CallLogManager(int size)
    {
        logs = new CallLog[size];
        count = 0;
    }

    public void AddCallLog(CallLog log)
    {
        if (count < logs.Length)
        {
            logs[count] = log;
            count++;
        }
        else
        {
            Console.WriteLine("Call log storage is full.");
        }
    }

    
    public void SearchByKeyword(string keyword)
    {
        Console.WriteLine("\nSearch Results for keyword: " + keyword);

        for (int i = 0; i < count; i++)
        {
            if (logs[i].Message.Contains(keyword))
            {
                Console.WriteLine(logs[i]);
            }
        }
    }

    public void FilterByTime(DateTime start, DateTime end)
    {
        Console.WriteLine("\nLogs between " + start + " and " + end);

        for (int i = 0; i < count; i++)
        {
            if (logs[i].TimeStamp >= start && logs[i].TimeStamp <= end)
            {
                Console.WriteLine(logs[i]);
            }
        }
    }
}


internal class Program
{
    static void Main(string[] args)
    {
        CallLogManager manager = new CallLogManager(5);

        manager.AddCallLog(new CallLog("9876543210", "Product enquiry", DateTime.Now.AddHours(-3)));
        manager.AddCallLog(new CallLog("9123456780", "Billing problem", DateTime.Now.AddHours(-2)));
        manager.AddCallLog(new CallLog("9988776655", "return issue", DateTime.Now.AddHours(5)));

        manager.SearchByKeyword("Billing");
        manager.FilterByTime(DateTime.Now.AddHours(-6), DateTime.Now);
    }
}