using System;
class ExtendedUnitConvertor2{
    static void Main(string[] args){
        double farhenheit = double.Parse(Console.ReadLine());
        double celsius = double.Parse(Console.ReadLine());
        double pounds = double.Parse(Console.ReadLine());
        double kilograms = double.Parse(Console.ReadLine());
        double gallons = double.Parse(Console.ReadLine());
        double liters = double.Parse(Console.ReadLine());

        Console.WriteLine("Fahrenheit to Celsius = " + ConvertFarhenheitToCelsius(farhenheit));
        Console.WriteLine("Pounds to Kilograms = " + ConvertPoundsToKilograms(pounds));
        Console.WriteLine("Gallons to Liters = " + ConvertGallonsToLiters(gallons));
		Console.WriteLine("Celsius to Fahrenheit = " + ConvertCelsiusToFarhenheit(celsius));
        Console.WriteLine("Liters to Gallons = " + ConvertLitersToGallons(liters));
		Console.WriteLine("Kilograms to Pounds = " + ConvertKilogramsToPounds(kilograms));
    }
    public static double ConvertFarhenheitToCelsius(double farhenheit){
        double farhenheittocelsius = (farhenheit - 32) * 5 / 9;
        return farhenheittocelsius;
    }

    public static double ConvertPoundsToKilograms(double pounds){
        double poundstokilograms = 0.453592;
        return pounds * poundstokilograms;
    }
	
	public static double ConvertCelsiusToFarhenheit(double celsius){
        double celsiustofarhenheit = (celsius * 9 / 5) + 32;
        return celsiustofarhenheit;
    }
	

    public static double ConvertKilogramsToPounds(double kilograms){
        double kilogramstopounds = 2.20462;
        return kilograms * kilogramstopounds;
    }

    public static double ConvertLitersToGallons(double liters){
        double literstogallons = 0.264172;
        return liters * literstogallons;
    }
	
	public static double ConvertGallonsToLiters(double gallons){
        double gallonstoliters = 3.78541;
        return gallons * gallonstoliters;
    }
	
	
}
