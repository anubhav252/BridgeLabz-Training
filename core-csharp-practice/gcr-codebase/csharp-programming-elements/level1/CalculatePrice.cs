using System;

class CalculatePrice{
	static void Main(string[] args){
		double unitPrice = Convert.ToDouble(Console.ReadLine());
		double quant = Convert.ToDouble(Console.ReadLine());
		
		double sum = unitPrice*quant; //calculate total price 
		
		Console.WriteLine("The total purchase price is INR "+sum+" if the quantity "+quant+ " and unit price is INR " +unitPrice);
	}
}
