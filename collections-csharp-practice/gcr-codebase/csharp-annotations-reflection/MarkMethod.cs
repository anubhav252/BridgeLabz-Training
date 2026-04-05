using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
    public string Level { get; set; }

    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}
class ServiceManager
{
    [ImportantMethod]
    public void SaveData()
    {
        Console.WriteLine("Data saved.");
    }

    [ImportantMethod("MEDIUM")]
    public void LoadData()
    {
        Console.WriteLine("Data loaded.");
    }

    public void HelperMethod()
    {
        Console.WriteLine("Helper method.");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(ServiceManager);
        MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);

        Console.WriteLine("Important Methods:\n");

        foreach (MethodInfo method in methods)
        {
            ImportantMethodAttribute attr =method.GetCustomAttribute<ImportantMethodAttribute>();

            if (attr != null)
            {
                Console.WriteLine(
                    $"Method: {method.Name}, Importance Level: {attr.Level}"
                );
            }
        }
    }
}
