using System;

class CalculateRounds{
	static void Main(string[] args){
		
		double side_1 = Convert.ToDouble(Console.ReadLine());
		double side_2 = Convert.ToDouble(Console.ReadLine());
		double side_3 = Convert.ToDouble(Console.ReadLine());
		
		double perimeter = (side_1+side_2+side_3)/1000;
		
		double noOfRounds = 5/perimeter;
		
		Console.WriteLine("The total number of rounds the athlete will run is "+noOfRounds +" to complete 5 km" );
	}
}
