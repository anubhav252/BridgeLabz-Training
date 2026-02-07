using System;
using System.Reflection;

class Student
{
    public int Id;
    public string Name;

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Display()
    {
        System.Console.WriteLine($"ID: {Id}, Name: {Name}");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Student);

        object studentObj = Activator.CreateInstance(type,new object[] { 101, "Rahul" });

        MethodInfo displayMethod = type.GetMethod("Display");
        displayMethod.Invoke(studentObj, null);
    }
}
