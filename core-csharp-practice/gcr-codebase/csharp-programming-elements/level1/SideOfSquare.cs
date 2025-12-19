using System;

class PerimeterOfSquare{
	static void Main(string[] args){
		double perimeter = Convert.ToDouble(Console.ReadLine());
		
		double sideOfSquare = perimeter/4;
		
		Console.WriteLine(" The length of the side is " + sideOfSquare + " whose perimeter is " + perimeter);
	}
}
