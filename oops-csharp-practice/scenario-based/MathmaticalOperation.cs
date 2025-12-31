/*2. Scenario: You are tasked with creating a utility class for mathematical operations.
Implement the following functionalities using separate methods:
● A method to calculate the factorial of a number.
● A method to check if a number is prime.
● A method to find the greatest common divisor (GCD) of two numbers.
● A method to find the nth Fibonacci number.
● Test your methods with various inputs, including edge cases like zero, one, and
negative numbers.*/



using System;

class Utility{
	public void Factorial(int num){
		int product = 1;
		while(num>1){
			product = product*num;
			num--;
		}
		Console.WriteLine("Factorial : "+product);
	}
	
	public void PrimeNo(int num){
		int c = 0;
		for(int i=0;i<=num/2;i++){
			if(num%i==0)
				c++;
		}
		if(c==1)
			Console.WriteLine("Its a prime");
		else
			Console.WriteLine("Its not a prime");
	}
	
	public void GCD(int num1,int num2){
		int highest = 0;
		for(int i =1;i<num1;i++){
			if(num1%i ==0 && num2%i ==0){
				if(i>highest){
					highest =i;
				}
			}
		}
		Console.WriteLine("GCD : " + highest);
	}
	
	
	public void Fibonacci(int num){
		int a =0,b=1,c=0;
		
		Console.Write("Fibonacci : " );
		for(int i =0;i<num;i++){
			c = a+b;
			a = b;
			b = c;
		}
		Console.Write(a);
	}
}
	
	
	
class MathematicalOperation{
	static void Main(string[] arrgs){
		MathematicalOperation obj = new MathematicalOperation();
		obj.Menu();
	}
	void Menu(){
		Utility utility = new Utility();
		while(true){
			
			Console.WriteLine("==Mathematical Operations==");
			Console.WriteLine("1. Factorial");
			Console.WriteLine("2. PrimeNo. Number");
			Console.WriteLine("3. Fibonacci");
			Console.WriteLine("4. Greatest Common Divisor");
			Console.WriteLine("5. Exit");
			int num = int.Parse(Console.ReadLine());
			switch(num){
				case 1:
					Console.WriteLine("Enter a number : ");
					int num = int.Parse(Console.ReadLine());
					utility.Factorial(num);
					break;
				case 2:
					Console.WriteLine("Enter a number : ");
					int num = int.Parse(Console.ReadLine());
					utility.PrimeNo();
					break;
				case 3:
					Console.WriteLine("Enter a number : ");
					int num = int.Parse(Console.ReadLine());
					utility.Fibonacci();
					break;
				case 4:
					Console.WriteLine("Enter two numbers to find GCD : ");
					int num1 = int.Parse(Console.ReadLine());
					int num2 = int.Parse(Console.ReadLine());
					utility.GCD();
					break;
				case 5:
					return;
				default:
					Console.WriteLine("Invalid Choice");
					break;
			}
		}
	}
}