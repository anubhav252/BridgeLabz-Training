using System;
class LaunchCount{
	static void Main(string[] args){
		int count=Convert.ToInt32(Console.ReadLine());
		while(count!=1){
			
			count--;
			Console.WriteLine(count);
		}
	}
}