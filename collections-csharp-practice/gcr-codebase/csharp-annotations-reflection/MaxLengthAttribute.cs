using System;
using System.Reflection;
[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
    public int Length { get; }

    public MaxLengthAttribute(int length)
    {
        Length = length;
    }
}

class User
{
    [MaxLength(10)]
    private string username;

    public User(string username)
    {
        FieldInfo field =
            typeof(User).GetField("username",BindingFlags.NonPublic | BindingFlags.Instance);

        MaxLengthAttribute attr =(MaxLengthAttribute)Attribute.GetCustomAttribute(field,typeof(MaxLengthAttribute));

        if (attr != null && username.Length > attr.Length)
        {
            throw new ArgumentException($"Username exceeds maximum length of {attr.Length}");
        }

        this.username = username;
    }

    public string Username => username;
}
class Program
{
    static void Main()
    {
        try
        {
            User user1 = new User("Rahul123");
            Console.WriteLine("User created: " + user1.Username);

            User user2 = new User("VeryLongUsername123");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
