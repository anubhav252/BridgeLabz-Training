using System;
class CentimeterToInche{
	static void Main(string[] args){
		float centimeter=float.Parse(Console.ReadLine());
		float heightInFoot=(centimeter/(12f*2.54f));
		float heightInInche=centimeter/2.54f;
		Console.WriteLine("Your Height in cm is "+ centimeter + 
		" while in feet is "+ heightInFoot +
		" and inches is " + heightInInche);
	}
}	