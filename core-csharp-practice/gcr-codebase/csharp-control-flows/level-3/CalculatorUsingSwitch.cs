using System;
class CablculatorUsingSwitch{
	static void Main(string[] args){
		double num1 =Convert.ToDouble(Console.ReadLine());
		double num2 =Convert.ToDouble(Console.ReadLine());
		string operation=Console.ReadLine();
		
		switch (operation){
			case "+" : Console.WriteLine(num1 + num2);
			break;
			case "-" : Console.WriteLine(num1 - num2);
			break;
			case "*" : Console.WriteLine(num1 * num2);
			break;
			case "/" : Console.WriteLine(num1 / num2);
			break;
			default : Console.WriteLine("invalid operation");
			break;
		}
	}
}