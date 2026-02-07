using System;
using System.Collections.Generic;
using System.Reflection;

class Student
{
    public int Id;
    public string Name;
    public int Age;
}

class ObjectMapper
{
    public static T ToObject<T>(Type clazz, Dictionary<string, object> properties)
    {
        object obj = Activator.CreateInstance(clazz);

        foreach (var item in properties)
        {
            FieldInfo field = clazz.GetField(item.Key,BindingFlags.Public | BindingFlags.Instance);

            if (field != null)
            {
                field.SetValue(obj, Convert.ChangeType(item.Value, field.FieldType));
            }
        }

        return (T)obj;
    }
}

class Program
{
    static void Main()
    {
        Dictionary<string, object> data =
            new Dictionary<string, object>
            {
                { "Id", 101 },
                { "Name", "Rahul" },
                { "Age", 20 }
            };

        Student student =ObjectMapper.ToObject<Student>(typeof(Student), data);

        Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
    }
}
