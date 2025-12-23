using System;
class TableUsingArray{
	static void Main(string[] args){
		int num=int.Parse(Console.ReadLine());
		int[] table=new int[11];
		for(int i=1;i<=10;i++){
			table[i]=num*i;
		}
		for(int i=1;i<=10;i++){
			Console.WriteLine(num +" * "+ i+" = "+ table[i]);
		}			
			
	}
}