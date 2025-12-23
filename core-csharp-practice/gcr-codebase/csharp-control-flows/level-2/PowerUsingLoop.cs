using System;
class PowerUsingLoop{
	static void Main(string[] args){
		int num=int.Parse(Console.ReadLine());
		int pow=int.Parse(Console.ReadLine());
		double result=1;
		for(int i=1;i<=pow;i++){
			result=result*num;
		}
		Console.WriteLine(result);
	
	}
}