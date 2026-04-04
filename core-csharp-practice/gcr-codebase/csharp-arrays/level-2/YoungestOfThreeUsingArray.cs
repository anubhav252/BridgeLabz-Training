using System;
class YoungestOfThreeUsingArray{
	static void Main(string[] args){
		string[] name={"Amar","Akbar","Anthony"};
		int[] age=new int[3];
		int[] height=new int[3];
		
		int smallestAge=99999;
		int idxAge=0;
		int tallest=0;
		int idxHeight=0;
		
		
		Console.WriteLine("Enter Age : ");
		for(int i=0;i<3;i++){
			age[i]=int.Parse(Console.ReadLine());
			if(age[i]<smallestAge){
				smallestAge=age[i];
				idxAge=i;
			}
		}
		
		Console.WriteLine("Enter height : ");
		for(int i=0;i<3;i++){
			height[i]=int.Parse(Console.ReadLine());
			if(height[i]>tallest){
				tallest=height[i];
				idxHeight=i;
			}
		}
		
		Console.WriteLine("youngest : "+name[idxAge]+ " : "+smallestAge+
		"\ntallest : "+name[idxHeight]+" : " + tallest);
	}
}