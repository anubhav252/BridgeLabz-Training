using System;

using System.Reflection;
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description { get; set; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}
class Application
{
    [BugReport("Null reference issue on login")]
    [BugReport("Performance slowdown when loading dashboard")]
    public void Run()
    {
        Console.WriteLine("Application running...");
    }
}


class Program
{
    static void Main()
    {
        Type type = typeof(Application);
        MethodInfo method = type.GetMethod("Run");

        object[] attributes =method.GetCustomAttributes(typeof(BugReportAttribute), false);

        Console.WriteLine("Bug Reports:\n");

        foreach (BugReportAttribute bug in attributes)
        {
            Console.WriteLine("- " + bug.Description);
        }
    }
}
