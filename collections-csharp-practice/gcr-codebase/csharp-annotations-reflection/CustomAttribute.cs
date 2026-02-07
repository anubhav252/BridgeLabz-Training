using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute : Attribute
{
    public string Priority { get; set; }
    public string AssignedTo { get; set; }

    public TaskInfoAttribute(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}
class TaskManager
{
    [TaskInfo("High", "Rahul")]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed.");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(TaskManager);

        MethodInfo method = type.GetMethod("CompleteTask");

        TaskInfoAttribute attr =(TaskInfoAttribute)Attribute.GetCustomAttribute(method,typeof(TaskInfoAttribute));
        if (attr != null)
        {
            Console.WriteLine("Task Information:");
            Console.WriteLine("Priority   : " + attr.Priority);
            Console.WriteLine("Assigned To: " + attr.AssignedTo);
        }
    }
}
