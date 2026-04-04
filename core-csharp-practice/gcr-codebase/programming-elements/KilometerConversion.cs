using System;
class KilometerConversion {
    public static void Main(String[] args) {
        
        double kmeter = Convert.ToDouble(Console.ReadLine());
        double mil = kmeter * 0.621371;

        Console.WriteLine(mil);
    }
}
