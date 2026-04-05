using System;
class SumOfNUsingRecursion{
	static void Main(string[] args){
		int num=int.Parse(Console.ReadLine());
		if(num<=0){
			Console.WriteLine("invalid");
			return;
		}
		int ans1=SumOfN1(num);
		int ans2=SumOfN2(num);
		Console.WriteLine("ans1 : "+ans1+"\nans2 : "+ans2+"\ndifference : "+(ans1-ans2));
	}
	static int SumOfN1(int num){
		int sum=num*(num+1)/2;
		return sum;
	}
	static int SumOfN2(int num){
		if(num==1){
			return 1;
		}
		return num+SumOfN2(num-1);
	}
}
		