using System;
class HarshadNo{
	static void Main(string[] args){
		int num=Convert.ToInt32(Console.ReadLine());
		int sum=0;
		int harshadNumber=num;
		while(num!=0){
			int remainder=num%10;
			sum=sum+remainder;
			num=num/10;
		}
		if(harshadNumber%sum==0){
			Console.WriteLine("Harshad Number");
		}
		else{
			Console.WriteLine("Not a Harshad Number");
		}
	}
}