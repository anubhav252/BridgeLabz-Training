using System;

class AreaOfTriangle{
	static void Main(string[] args){
		double heightOfTriangle = Convert.ToDouble(Console.ReadLine());
		double baseOfTriangle = Convert.ToDouble(Console.ReadLine());
		
		double AreaOfTriangle = 0.5 * heightOfTriangle * baseOfTriangle;
		
		Console.WriteLine("Area of Triangle is " + AreaOfTriangle);
	}
}
