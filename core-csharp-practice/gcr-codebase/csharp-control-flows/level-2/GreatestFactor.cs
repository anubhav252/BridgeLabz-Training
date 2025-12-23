using System;
class GreatestFactor{
	static void Main(string[] args){
		int num=int.Parse(Console.ReadLine());
		int factor=0;
		for(int i=1;i<num;i++){
			if(num%i==0){
				factor=Math.Max(factor,i);
			}
		}
		Console.WriteLine(factor);
	}
}