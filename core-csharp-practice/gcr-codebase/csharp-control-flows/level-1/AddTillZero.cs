using System;
class AddTillZero{
	static void Main(string[] args){
		double total= 0.0;
		
		double userInput=Convert.ToDouble(Console.ReadLine());
		while(userInput!=0){
			total=total+userInput;
			userInput=Convert.ToDouble(Console.ReadLine());
		}
		Console.WriteLine(total);
	}
}