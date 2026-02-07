using System;
using System.Threading;
using System.Reflection;
using System.Diagnostics;

class WorkTasks
{
    public void TaskA()
    {
        Thread.Sleep(300);
    }

    public void TaskB()
    {
        Thread.Sleep(700);
    }

    public void TaskC()
    {
        Thread.Sleep(150);
    }
}

class Program
{
    static void Main()
    {
        WorkTasks obj = new WorkTasks();
        Type type = typeof(WorkTasks);

        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

        foreach (MethodInfo method in methods)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            method.Invoke(obj, null);
            stopwatch.Stop();

            Console.WriteLine($"Method: {method.Name} | Time: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
