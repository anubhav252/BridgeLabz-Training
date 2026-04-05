using System;
class MultiplicationTable{
	static void Main(string[] args){
		int num=int.Parse(Console.ReadLine());
		int[] table=new int[4];
		int j=0;
		for(int i=6;i<=9;i++){
			table[j]=num*i;
			j++;
		}
		int k=0;
		for(int i=6;i<=9;i++){
			Console.WriteLine(num +" * "+ i+" = "+ table[k]);
			k++;
		}			
			
	}
}