using System;
class LargestOfThree{
	static void Main(string[] args){
		int num1=Convert.ToInt32(Console.ReadLine());
		int num2=Convert.ToInt32(Console.ReadLine());
		int num3=Convert.ToInt32(Console.ReadLine());
		bool isNum1=(num1>num2) && (num1>num3);
		bool isNum2=(num2>num1) && (num2>num3);
		bool isNum3=(num3>num1) && (num3>num2);
		Console.WriteLine("Is the first number the largest? "+isNum1 +
                          "\nIs the second number the largest?" +isNum2+
                          "\nIs the third number the largest?" +isNum3);
	}
}