using System;
class EvenOrOdd{
	static void Main(string[] args){
		int num=int.Parse(Console.ReadLine());
		int[] even=new int[num/2+1];
		int[] odd=new int[num/2+1];
		int even_count=0;
		int odd_count=0;
		for(int i=1;i<=num;i++){
			if(i%2==0){
				even[even_count]=i;
				even_count++;
			}
			else{
				odd[odd_count]=i;
				odd_count++;
			}
		}
		Console.WriteLine("Even no. : ");
		if(even[even.Length-1]==0){
			for(int i=0;i<even.Length-1;i++){
				Console.WriteLine(even[i]);
			}
				
		}
		else{
			for(int i=0;i<even.Length;i++){
				Console.WriteLine(even[i]);
			}
		}
		
		Console.WriteLine("\nOdd no. : ");
		if(odd[odd.Length-1]==0){
			for(int i=0;i<odd.Length-1;i++){
				Console.WriteLine(odd[i]);
			}
				
		}
		else{
			for(int i=0;i<odd.Length;i++){
				Console.WriteLine(odd[i]);
			}
		}
	}
}