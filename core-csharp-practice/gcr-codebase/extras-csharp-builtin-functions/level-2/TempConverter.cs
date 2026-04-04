using System;
class TempConverter{
    static void Main(string[] args){
        double temperature = GetTemperature();
        char choice = GetChoice();

        if (choice == 'F'){
            double celsius = FahrenheitToCelsius(temperature);
            DisplayResult("Celsius", celsius);
        }
        else if (choice == 'C'){
            double fahrenheit = CelsiusToFahrenheit(temperature);
            DisplayResult("Fahrenheit", fahrenheit);
        }
        else{
            Console.WriteLine("Invalid choice");
        }
    }

    static double GetTemperature(){
        return double.Parse(Console.ReadLine());
    }

    static char GetChoice(){
        return char.Parse(Console.ReadLine().ToUpper());
    }

    static double FahrenheitToCelsius(double fahrenheit){
        return (fahrenheit - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double celsius){
        return (celsius * 9 / 5) + 32;
    }

    static void DisplayResult(string unit, double value){
        Console.WriteLine("Converted Temperature in " + unit + " is: " + value);
    }
}
