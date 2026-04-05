using System;

class BMIUsingTwoD{
	static void Main(string[] args){
		Console.WriteLine("Enter no of person : ");
		int num = int.Parse(Console.ReadLine());
		double[,] personData = new double[num,3];
		string[]  status = new string[num];
		double weight;
		double height;
		
		for(int i =0;i<num;i++){
			
			Console.WriteLine("Enter weight : ");
			while(true){
				weight = double.Parse(Console.ReadLine());
				if(weight<0){
					Console.WriteLine("Enter positive value");
				}
				else{
					personData[i,0] = weight;
					break;
				}
			}
			
			Console.WriteLine("Enter height : ");
			while(true){
				height = double.Parse(Console.ReadLine());
				if(height<0){
					Console.WriteLine("Enter positive value");
				}
				else{
					personData[i,1] = height/100;
					break;
				}
			}
			
			double BMI = weight/(height * height);
			personData[i,2] = BMI;
		}
		
		for(int i =0;i<num;i++){
			if(personData[i,2] <= 18.4){
				status[i] = "UnderWeight";
			}
			else if(personData[i,2] >= 18.5 && personData[i,2] <= 24.9){
				status[i]="Normal";
			}
			else if(personData[i,2] >= 25.0 && personData[i,2] <= 39.9){
				status[i] = "OverWeight";
			}
			else{
				status[i] = "Obese";
			}
		}
		
		Console.WriteLine("Status : ");
		for(int i =0;i<num;i++){
			Console.WriteLine("\nPerson " + (i+1));
			for(int j =0;j<3;j++){
				Console.Write(personData[i,j]+" ");
			}
			Console.Write(status[i]);
		}
	}
}