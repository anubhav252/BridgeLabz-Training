using System;
class PenDistribution{
	static void Main(){
		int penCount=14;
		int Students=3;
		int penPerStudent=14/3;
		int remainingPen=14%3;
		Console.WriteLine("The pen per student is " + penPerStudent + 
		" and the remaining pen not distributed is " + remainingPen);
	}
}	