using System;

class FeetConversion{
    static void Main(string[] args){
        double feet = Convert.ToDouble(Console.ReadLine());

        double yard = feet / 3;
        double mile = yard / 1760;

        Console.WriteLine("The distance in yards is " + yard +
		" and the distance in miles is " + mile);
    }
}
