using System;
using System.Reflection;
class Program
{
    static void Main()
    {
        Console.Write("Enter fully qualified class name: ");
        string className = Console.ReadLine();

        Type type = Type.GetType(className);

        if (type == null)
        {
            Console.WriteLine("Class not found.");
            return;
        }

        Console.WriteLine("\n--- Constructors ---");
        foreach (ConstructorInfo ctor in type.GetConstructors())
        {
            Console.WriteLine(ctor);
        }

        Console.WriteLine("\n--- Fields ---");
        foreach (FieldInfo field in type.GetFields(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            Console.WriteLine(field);
        }

        Console.WriteLine("\n--- Methods ---");
        foreach (MethodInfo method in type.GetMethods(
            BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
        {
            Console.WriteLine(method);
        }
    }
}
