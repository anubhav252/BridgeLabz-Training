using System;
using System.Reflection;
using System.Text;

[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute
{
    public string Name { get; set; }

    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}
class User
{
    [JsonField("user_name")]
    public string Username;

    [JsonField("user_email")]
    public string Email;

    [JsonField("user_age")]
    public int Age;

    public User(string username, string email, int age)
    {
        Username = username;
        Email = email;
        Age = age;
    }
}

class JsonSerializerCustom
{
    public static string ToJson(object obj)
    {
        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields();

        StringBuilder json = new StringBuilder();
        json.Append("{");

        bool first = true;

        foreach (FieldInfo field in fields)
        {
            JsonFieldAttribute attr =field.GetCustomAttribute<JsonFieldAttribute>();

            if (attr != null)
            {
                if (!first)
                    json.Append(",");

                object value = field.GetValue(obj);

                json.Append($"\"{attr.Name}\":");

                if (value is string)
                    json.Append($"\"{value}\"");
                else
                    json.Append(value);

                first = false;
            }
        }

        json.Append("}");
        return json.ToString();
    }
}

class Program
{
    static void Main()
    {
        User user = new User("rahul_01","rahul@gmail.com",22);

        string json = JsonSerializerCustom.ToJson(user);
        Console.WriteLine(json);
    }
}
