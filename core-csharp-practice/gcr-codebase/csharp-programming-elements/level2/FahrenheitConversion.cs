using System;

class FahrenheitConversion{
	static void Main(string[] args){
		double fah = Convert.ToDouble(Console.ReadLine());
		double celcius = (fah-32)*5/9;
		
		Console.WriteLine("The "+fah+" Fahrenheit is "+celcius+" Celcius");
	}
}