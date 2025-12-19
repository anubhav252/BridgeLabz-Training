using System;
class VolOfEarth{
	static void Main(){
		double radius=6378;
		double volumeInKm=(4/3)*3.14*(Math.Pow(radius,3));
		double volumeInMile=volumeInKm/1.6f;
		Console.WriteLine("The volume of earth in cubic kilometers is"+ volumeInKm +
		" and cubic miles is "+ volumeInMile);
	}
}	