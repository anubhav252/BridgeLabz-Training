using System;
class SumOfN{
	static void Main(string[] args){
		int month=Convert.ToInt32(Console.ReadLine());
		int day=Convert.ToInt32(Console.ReadLine());
		if((month>=3 && day>=20) || month==4 || month==5 || (month==6 && day<=20)){
			Console.WriteLine("Its a spring season ");
		}
		else{
			Console.WriteLine("Not a spring season");
		}
	}
}