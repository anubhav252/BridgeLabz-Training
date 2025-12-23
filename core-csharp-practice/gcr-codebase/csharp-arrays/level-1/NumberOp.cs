using System;
class NumberOp{
	static void Main(string[] args){
		int[] num=new int[5];
		for(int i=0;i<num.Length;i++){
			num[i]=int.Parse(Console.ReadLine());
		}
		for(int i=0;i<num.Length;i++){
			if(num[i]>0){
				if(num[i]%2==0){
					Console.WriteLine("positive even number");
				}
				else{
					Console.WriteLine("positive odd number");
				}
			}
			else if(num[i]==0){
				Console.WriteLine("zero");
			}
			else{
				Console.WriteLine("negative number");
			}
		}
		if(num[0]==num[num.Length-1]){
			Console.WriteLine("first == last ");
		}
		else if (num[0]>num[num.Length-1]){
			Console.WriteLine("first > last");
		}
		else {
			Console.WriteLine("first < last");
		}
	}
}