using System;
class FactorUsingArray{
	static void Main(string[] args){
		int num=int.Parse(Console.ReadLine());
		int count=0;
		for(int i=1;i<num;i++){
			if(num%i==0){
				count++;
			}
		}
		int[] factor=new int[count];
		int idx=0;
		for(int i=1;i<num;i++){
			if(num%i==0){
				factor[idx]=i;
				idx++;
			}
		}
		for(int i=0;i<factor.Length;i++){
			Console.WriteLine(factor[i]);
		}
	}
}