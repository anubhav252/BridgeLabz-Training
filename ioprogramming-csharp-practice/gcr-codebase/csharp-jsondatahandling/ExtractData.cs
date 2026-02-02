using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

class User
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("email")]
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("data.json");

        User user = JsonSerializer.Deserialize<User>(json);

        Console.WriteLine("Name  : " + user.Name);
        Console.WriteLine("Email : " + user.Email);
    }
}
