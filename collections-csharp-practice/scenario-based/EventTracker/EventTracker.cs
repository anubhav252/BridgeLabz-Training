
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;

class EventTracker
{
    public static void GenerateAuditLogs()
    {
        List<AuditLog> logs = new List<AuditLog>();

        Assembly assembly = Assembly.GetExecutingAssembly();

        foreach (Type type in assembly.GetTypes())
        {
            MethodInfo[] methods =type.GetMethods(BindingFlags.Instance |BindingFlags.Public |BindingFlags.DeclaredOnly);

            foreach (MethodInfo method in methods)
            {
                AuditTrailAttribute audit =method.GetCustomAttribute<AuditTrailAttribute>();

                if (audit != null)
                {
                    logs.Add(new AuditLog
                    {
                        ClassName = type.Name,
                        MethodName = method.Name,
                        Action = audit.ActionName,
                        Timestamp = DateTime.Now
                    });
                }
            }
        }

        string json = JsonSerializer.Serialize(logs,new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine(json);
    }
}
class Program
{
    static void Main()
    {
        EventTracker.GenerateAuditLogs();
    }
}
