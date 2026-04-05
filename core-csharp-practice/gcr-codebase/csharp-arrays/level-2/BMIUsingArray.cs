using System;
class BMIUsingArray{
	static void Main(string[] args){
		Console.WriteLine("Enter no of person : ");
		int num=int.Parse(Console.ReadLine());
		double[] weights=new double[num];
		double[] heights=new double[num];
		double[] BMI=new double[num];
		
		Console.WriteLine("Enter weight : ");
		for(int i=0;i<weights.Length;i++){
			weights[i]=double.Parse(Console.ReadLine());
		}
		
		Console.WriteLine("Enter height : ");
		for(int i=0;i<heights.Length;i++){
			heights[i]=double.Parse(Console.ReadLine());
			heights[i]=heights[i]/100;
		}
		for(int i=0;i<BMI.Length;i++){
			BMI[i]=(weights[i])/(heights[i]*heights[i]);
		}
		for(int i=0;i<BMI.Length;i++){
			if(BMI[i]<=18.4){
			    Console.WriteLine("height : "+heights[i]+" weight : "+weights[i]+
			" BMI : "+BMI[i] +" status : underweight" );
		    }
		    else if(BMI[i]<=24.9 && BMI[i]>=18.5){
			    Console.WriteLine("height : "+heights[i]+" weight : "+weights[i]+
			" BMI : "+BMI[i] +" status : Normal" );
		    }
		    else if(BMI[i]<=39.9 && BMI[i]>=25.0){
			    Console.WriteLine("height : "+heights[i]+" weight : "+weights[i]+
			" BMI : "+BMI[i] +" status : Overweight" );
		    }
		    else{
			    Console.WriteLine("height : "+heights[i]+" weight : "+weights[i]+
			" BMI : "+BMI[i] +" status : Obese" );
		    }
		}
	}

}