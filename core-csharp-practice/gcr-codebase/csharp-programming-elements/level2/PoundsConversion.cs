using System;

class PoundsConversion{
    static void Main(string[] args){
        double Pounds = Convert.ToDouble(Console.ReadLine());

        double Kilogram = Pounds/2.2;

        Console.WriteLine("The weight of the person in pounds is "+Pounds+ " and in kg is "+Kilogram);
    }
}
