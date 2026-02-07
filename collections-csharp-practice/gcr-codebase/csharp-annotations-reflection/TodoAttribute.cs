using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
    public string Task { get; set; }
    public string AssignedTo { get; set; }
    public string Priority { get; set; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}
class ProjectTasks
{
    [Todo("Implement login feature", "Rahul", "HIGH")]
    public void Login()
    {
    }

    [Todo("Add password encryption", "Anita")]
    [Todo("Improve validation", "Anita", "LOW")]
    public void SecurityModule()
    {
    }

    [Todo("Create report export feature", "Kiran")]
    public void Reports()
    {
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(ProjectTasks);
        MethodInfo[] methods = type.GetMethods(
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly
        );

        Console.WriteLine("Pending Todo Tasks:\n");

        foreach (MethodInfo method in methods)
        {
            object[] todos = method.GetCustomAttributes(typeof(TodoAttribute), false);

            foreach (TodoAttribute todo in todos)
            {
                Console.WriteLine($"Method      : {method.Name}");
                Console.WriteLine($"Task        : {todo.Task}");
                Console.WriteLine($"Assigned To : {todo.AssignedTo}");
                Console.WriteLine($"Priority    : {todo.Priority}");
                Console.WriteLine();
            }
        }
    }
}
