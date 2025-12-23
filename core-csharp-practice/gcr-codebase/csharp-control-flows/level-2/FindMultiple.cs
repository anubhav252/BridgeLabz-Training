using System;
class FindMultiple{
	static void Main(string[] args){
		int num=int.Parse(Console.ReadLine());
		for(int i=100;i>=1;i--){
			if(i%num==0){
				Console.WriteLine(i);
			}
		}
	}
}