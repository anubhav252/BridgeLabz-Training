using System;
class EvenOrOdd{
	static void Main(string[] args){
		int num=Convert.ToInt32(Console.ReadLine());
		if(num>0){
			for(int i=1;i<=num;i++){
				if(i%2==0){
					Console.WriteLine(i+" : even");
				}
				else{
					Console.WriteLine(i+" : odd");
				}
			}
		}
	}
}