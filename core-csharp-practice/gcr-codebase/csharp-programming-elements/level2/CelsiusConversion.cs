using System;

class CelciusConversion{
	static void Main(string[] args){
		double celcius = Convert.ToDouble(Console.ReadLine());
		double fah = (celcius*9/5)+32;
		
		Console.WriteLine("The "+celcius+" Celsius is "+fah+" Fahrenheit");
	}
}