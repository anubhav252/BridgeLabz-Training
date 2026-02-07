using System;
using System.Threading;
using System.Reflection;
using System.Diagnostics;
[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute
{
}

class PerformanceTasks
{
    [LogExecutionTime]
    public void FastTask()
    {
        Thread.Sleep(300);
    }

    [LogExecutionTime]
    public void SlowTask()
    {
        Thread.Sleep(800);
    }

    public void NormalTask()
    {
        Thread.Sleep(200);
    }
}


class Program
{
    static void Main()
    {
        PerformanceTasks obj = new PerformanceTasks();
        Type type = typeof(PerformanceTasks);

        MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);

        foreach (MethodInfo method in methods)
        {
            if (method.GetCustomAttribute<LogExecutionTimeAttribute>() != null)
            {
                Stopwatch sw = new Stopwatch();

                sw.Start();
                method.Invoke(obj, null);
                sw.Stop();

                Console.WriteLine($"Method: {method.Name} | Execution Time: {sw.ElapsedMilliseconds} ms");
            }
        }
    }
}
