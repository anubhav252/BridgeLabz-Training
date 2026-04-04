using System;
class UnitConvertorUsingMethod{
    static void Main(string[] args){
        double km = double.Parse(Console.ReadLine());
        double miles = double.Parse(Console.ReadLine());
        double meters = double.Parse(Console.ReadLine());
        double feet = double.Parse(Console.ReadLine());

        Console.WriteLine("km to Miles = " + ConvertKmToMiles(km));
        Console.WriteLine("Miles to km = " + ConvertMilesToKm(miles));
        Console.WriteLine("Meters to Feet = " + ConvertMetersToFeet(meters));
        Console.WriteLine("Feet to Meters = " + ConvertFeetToMeters(feet));
    }
    public static double ConvertKmToMiles(double km){
        double kmtomiles = 0.621371;
        return km * kmtomiles;
    }
	
	 public static double ConvertFeetToMeters(double feet){
        double feettometers = 0.3048;
        return feet * feettometers;
    }

    public static double ConvertMetersToFeet(double meters){
        double meterstofeet = 3.28084;
        return meters * meterstofeet;
    }
	
	public static double ConvertMilesToKm(double miles){
        double milestokm = 1.60934;
        return miles * milestokm;
    }
}
