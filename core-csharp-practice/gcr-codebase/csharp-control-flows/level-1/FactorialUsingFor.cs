using System;
class FactorialUsingFor{
	static void Main(string[] args){
		int num=Convert.ToInt32(Console.ReadLine());
		int factorial=1;
		if(num>0){
			for(int i=num;i>0;i--){
				factorial=factorial*num;
				num--;
			}
		}
		Console.WriteLine(factorial);
	}
}