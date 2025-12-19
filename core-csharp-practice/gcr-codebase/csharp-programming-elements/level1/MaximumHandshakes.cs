using System;

class MaximumHandshakes{
	static void Main(string[] args){
		double totalStudents = Convert.ToDouble(Console.ReadLine());
		double total = (totalStudents*(totalStudents-1))/2;
		
		Console.WriteLine("The total number of Handshakes is " +total);
	}
}
