using System;
class CountUsingFor{
	static void Main(string[] args){
		int count=Convert.ToInt32(Console.ReadLine());
		for(int i=count;i>1;i--){
			count--;
			Console.WriteLine(count);
			
		}
	}
}