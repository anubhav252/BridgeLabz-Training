using System;
class ReverseNo{
	static void Main(string[] args){
		int num=int.Parse(Console.ReadLine());
		int count=0;
		int temp=num;
		while(temp!=0){
			temp=temp/10;
			count++;
		}
		int[] reversed=new int[count];
		int idx=0;
		
		while(num!=0){
			reversed[idx]=num%10;
			num=num/10;
			idx++;
		}
		Console.Write("reversed no. : ");
		for(int i=0;i<reversed.Length;i++){
			Console.Write(reversed[i]);
		}
		
	}
}