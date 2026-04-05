using System;
class SumOfNUsingFor{
	static void Main(string[] args){
		int num=Convert.ToInt32(Console.ReadLine());
		int sum1=0,sum2=0;
		if(num>0){
			sum1=num*((num+1)/2);
			
			for(int i=num;i>0;i--){
				sum2=sum2+num;
				num--;
			}
		}
		if(sum1==sum2){
			Console.WriteLine(sum2);
		}
	}
}