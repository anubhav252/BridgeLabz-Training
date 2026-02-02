using System;
using System.Text.Json;

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
}

class Program
{
    static void Main()
    {
        Car car = new Car
        {
            Brand = "Toyota",
            Model = "Corolla"
        };

        string json = JsonSerializer.Serialize(car,new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine(json);
    }
}
