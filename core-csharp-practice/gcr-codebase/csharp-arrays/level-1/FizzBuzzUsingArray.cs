using System;
class FizzBuzzUsingArray{
	static void Main(string[] args){
		int num=int.Parse(Console.ReadLine());
		string[] ans=new string[num+1];
		if(num>=0){
			int i=0;
			while(i!=num+1){
				if(i==0){
					ans[i]=i.ToString();
				}
				else if(i%3==0 && i%5==0){
					ans[i]="FizzBuzz";
				}
				else if(i%3==0){
					ans[i]="Fizz";
				}
				else if(i%5==0){
					ans[i]="Buzz";
				}
				
				else {
					ans[i]=i.ToString();
				}
				i++;
			}
		}
		
			
		else {
			Console.WriteLine("invalid no.");
		}
		for(int i=1;i<=num;i++){
			Console.WriteLine(i+" = "+ans[i]);
		}
	}
}