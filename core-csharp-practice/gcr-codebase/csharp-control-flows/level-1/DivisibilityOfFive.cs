using System;
class DivisibilityOfFive{
	static void Main(string[] args){
		int num=Convert.ToInt32(Console.ReadLine());
	    bool isDivisible=(num%5==0);
		Console.WriteLine(" Is the number "+num+" divisible by 5? " +isDivisible);
	}
}