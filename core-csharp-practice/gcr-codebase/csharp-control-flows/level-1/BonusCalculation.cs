using System;
class BonusCalculation{
	static void Main(string[] args){
		double salary=Convert.ToDouble(Console.ReadLine());
		int yearOfService=Convert.ToInt32(Console.ReadLine());
		if(yearOfService>5){
			salary=salary+(5*(salary/100));
			Console.WriteLine(salary);
		}
		
	}
}