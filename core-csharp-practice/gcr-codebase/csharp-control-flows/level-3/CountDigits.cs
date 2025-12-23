using System;
class CountDigits{
	static void Main(string[] args){
		int num=Convert.ToInt32(Console.ReadLine());
		int count=0;
		while(num!=0){
			if(num%10>0){
				count++;
			}
			num=num/10;
		}
		Console.WriteLine(count);
		
	}
}