using System;
using System.Reflection;
[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}
[Author("Rahul Sharma")]
class SampleClass
{
    public void Display()
    {
        Console.WriteLine("Sample class method.");
    }
}


class Program
{
    static void Main()
    {
        Type type = typeof(SampleClass);

        AuthorAttribute attr =type.GetCustomAttribute<AuthorAttribute>();

        if (attr != null)
        {
            Console.WriteLine("Author Name: " + attr.Name);
        }
    }
}
