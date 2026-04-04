using System;
class KilometerToMileInput{
	static void Main(string[] args){
		float km=float.Parse(Console.ReadLine()); // take inpput in km
		float mile=km/1.6f;
		Console.WriteLine("The total miles is "+ mile+" mile for the given " + km + " km ");
			
	}
}	