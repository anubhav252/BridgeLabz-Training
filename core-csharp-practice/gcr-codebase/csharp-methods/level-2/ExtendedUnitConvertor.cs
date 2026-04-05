using System;
class ExtendedUnitConvertor{
    static void Main(string[] args){
        double yards = double.Parse(Console.ReadLine());
        double feet = double.Parse(Console.ReadLine());
        double meters = double.Parse(Console.ReadLine());
        double inches = double.Parse(Console.ReadLine());

        Console.WriteLine("Yards to Feet = " + ConvertYardsToFeet(yards));
        Console.WriteLine("Meters to Inches = " + ConvertMetersToInches(meters));
		        Console.WriteLine("Inches to Centimeters = " + ConvertInchesToCentimeters(inches));
        Console.WriteLine("Inches to Meters = " + ConvertInchesToMeters(inches));
		Console.WriteLine("Feet to Yards = " + ConvertFeetToYards(feet));
    }

    
    public static double ConvertYardsToFeet(double yards){
        double yardtofeet = 3;
        return yards * yardtofeet;
    }
	
    public static double ConvertInchesToMeters(double inches){
        double inchestometer = 0.0254;
        return inches * inchestometer;
    }

    public static double ConvertFeetToYards(double feet){
        double feettoyard = 0.333333;
        return feet * feettoyard;
    }
	public static double ConvertInchesToCentimeters(double inches){
        double inchetocm = 2.54;
        return inches * inchetocm;
    }

    public static double ConvertMetersToInches(double meters){
        double meterstoinche = 39.3701;
        return meters * meterstoinche;
    }


    
}
