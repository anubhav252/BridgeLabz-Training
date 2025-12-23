using System;
class FindBmi{
	static void Main(string[] args){
		double weight=double.Parse(Console.ReadLine());
		double height=double.Parse(Console.ReadLine());
		double height_m=height/100;
		double BMI=weight/(height*height);
		if(BMI<=18.4f){
			Console.WriteLine("Underweight");
		}
		else if(BMI<=24.9f && BMI>=18.5f){
			Console.WriteLine("Normal");
		}
		else if(BMI<=39.9f && BMI>=25.0f){
			Console.WriteLine("Overweight");
		}
		else{
			Console.WriteLine("Underweight");
		}
		
		
	}
}