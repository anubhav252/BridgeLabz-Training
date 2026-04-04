using System;
class SmallestOfThree{
	static void Main(string[] args){
		int num1=Convert.ToInt32(Console.ReadLine());
		int num2=Convert.ToInt32(Console.ReadLine());
		int num3=Convert.ToInt32(Console.ReadLine());
		bool isNum1=(num1<num2) && (num1<num3);
		
		Console.WriteLine("Is the first number the smallest? "+isNum1);
		}
}