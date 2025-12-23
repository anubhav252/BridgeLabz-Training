using System;
class YoungestOfThree{
	static void Main(string[] args){
		int Amar_age=int.Parse(Console.ReadLine());
		int Akbar_age=int.Parse(Console.ReadLine());
		int Anthony_age=int.Parse(Console.ReadLine());
		int Amar_height=int.Parse(Console.ReadLine());
		int Akbar_height=int.Parse(Console.ReadLine());
		int Anthony_height=int.Parse(Console.ReadLine());
		
		if(Amar_age<Akbar_age && Amar_age<Anthony_age){
			
			Console.WriteLine("youngest : Amar ");
		}
		else if(Amar_age>Akbar_age && Akbar_age<Anthony_age){
			
			Console.WriteLine("youngest : Akbar ");
		}
		else{
			
			Console.WriteLine("youngest : Anthony ");
		}
		if(Amar_height>Akbar_height && Amar_height>Anthony_height){
			
			Console.WriteLine("Tallest : Amar  ");
		}
		else if(Amar_height<Akbar_height && Akbar_height>Anthony_height){
			
			Console.WriteLine("Tallest : Akbar  ");
		}
		else{
			
			Console.WriteLine("Tallest : Anthony  ");
		}
		
		
	}
}