using System;
class DayOfWeek{
	static void Main(string[] args){
		int month=Convert.ToInt32(Console.ReadLine());
		int day=Convert.ToInt32(Console.ReadLine());
		int year=Convert.ToInt32(Console.ReadLine());
		
		int year_x = year-(14-month)/12;
		
		int x = year_x + year_x/4 - year_x/100 + year_x/400;
		
		int month_x = month +12*((14-month)/12)-2;
		
		int day_x = (day + x + 31*month_x/12)%7;
		
		switch (day_x){
			case 0 : Console.WriteLine("Sunday");
			break;
			case 1 : Console.WriteLine("Monday");
			break;
			case 2 : Console.WriteLine("Tuesday");
			break;
			case 3 : Console.WriteLine("Wednesday");
			break;
			case 4 : Console.WriteLine("Thursday");
			break;
			case 5 : Console.WriteLine("Friday");
			break;
			case 6: Console.WriteLine("Saturday");
			break;
			default : Console.WriteLine("invalid no.");
			break;
		}
	}
}