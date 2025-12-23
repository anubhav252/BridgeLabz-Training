using System;
class AbundantNumber{
	static void Main(string[] args){
		int num=Convert.ToInt32(Console.ReadLine());
		int sum=0;
		for(int i=1;i<num;i++){
			if(num%i==0){
				sum=sum+i;
			}
		}
		if(sum>num){
			Console.WriteLine("Abundant Number");
		}
		else{
			Console.WriteLine("Not a Abundant Number");
        }			
	}
}