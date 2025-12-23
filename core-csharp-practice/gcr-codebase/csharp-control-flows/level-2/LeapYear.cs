using System;
class LeapYear{
	static void Main(string[] args){
		int year=int.Parse(Console.ReadLine());
		if(year%4==0 && year%100!=0){
			Console.WriteLine("the year is a leap year");
		}
		else if (year%400==0){
			Console.WriteLine("the year is a leap year");
		}
		else {
			Console.WriteLine("the year is not a leap year");
		}
		
	}
}