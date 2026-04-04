using System;
class FizzBuzzUsingWhile{
	static void Main(string[] args){
		int num=int.Parse(Console.ReadLine());
		if(num>=0){
			int i=0;
			while(i!=num+1){
				if(i==0){
					Console.WriteLine(i);
				}
				else if(i%3==0 && i%5==0){
					Console.WriteLine("FizzBuzz");
				}
				else if(i%3==0){
					Console.WriteLine("Fizz");
				}
				else if(i%5==0){
					Console.WriteLine("Buzz");
				}
				
				else {
					Console.WriteLine(i);
				}
				i++;
			}
		}
		else {
			Console.WriteLine("invalid no.");
		}
	}
}