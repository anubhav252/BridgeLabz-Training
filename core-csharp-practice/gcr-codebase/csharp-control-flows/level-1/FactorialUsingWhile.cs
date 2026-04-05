using System;
class FactorialUsingWhile{
	static void Main(string[] args){
		int num=Convert.ToInt32(Console.ReadLine());
		int factorial=1;
		if(num>0){
			while(num!=0){
				factorial=factorial*num;
				num--;
			}
		}
		Console.WriteLine(factorial);
	}
}