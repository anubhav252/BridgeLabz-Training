using System;
class AddTillZeroUsingBreak{
	static void Main(string[] args){
		double total= 0.0;
		
		double userInput=Convert.ToDouble(Console.ReadLine());
		while(true){
			total=total+userInput;
			userInput=Convert.ToDouble(Console.ReadLine());
			if(userInput<=0.0){
				break;
			}
		}
		Console.WriteLine(total);
	}
}