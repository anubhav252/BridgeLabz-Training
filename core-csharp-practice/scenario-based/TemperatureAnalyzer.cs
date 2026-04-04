using System;
class TemperatureAnalyzer{
	static void Main(string[] args){
		GetInput();
	}
	
	static void GetInput(){
		Console.WriteLine("Enter temperature data : ");
		float[,] temperatureData=new float[7,24];
		for(int i=0;i<7;i++){
			for(int j=0;j<24;j++){
				temperatureData[i,j]=float.Parse(Console.ReadLine());
			}
		}
		Menu(temperatureData);
		
	}
	
	static void Menu(float[,] temperatureData){
		bool start=true;
		while(start){
			
			Console.WriteLine("1. to find hottest and coldest day");
			Console.WriteLine("2. to average temperature per day");
			Console.WriteLine("3. Exit");
			Console.WriteLine();
			int choice=int.Parse(Console.ReadLine());
		    switch(choice){
		    	case 1:{
		    		HottestAndColdest(temperatureData);
		    		break;
		    	}
		    	case 2:{
		    		AvgTemperature(temperatureData);
		    		break;
		    	}
		    	case 3:{
					return;
		    	}
		    	default :{
		    		break;
		    	}
		    }	
		}		
	}
	
	static double[] HottestAndColdest(float[,] temperatureData){
		double hottest=0;
		int hottestIdx=0;
		double coldest=999;
		int coldestIdx=0;
		double[] avg=new double[7];
		for(int i=0;i<7;i++){
			for(int j=0;j<24;j++){
				avg[i]=avg[i]+temperatureData[i,j];
			}
			avg[i]=avg[i]/24;
		}
        for(int i=0;i<avg.Length;i++){
			if(avg[i]>hottest){
				hottest=avg[i];
				hottestIdx=i;
			}
			else if(avg[i]<coldest){
				coldest=avg[i];
				coldestIdx=i;
			}
		}
        Console.WriteLine("hottest day : "+(hottestIdx+1)+"\ncoldest day : "+(coldestIdx+1));
        return avg;		
	}
	
	static void AvgTemperature(float[,] temperatureData){
		double[] avg=new double[7];
		for(int i=0;i<7;i++){
			for(int j=0;j<24;j++){
				avg[i]=avg[i]+temperatureData[i,j];
			}
			avg[i]=avg[i]/24.00;
		}
		for(int i=0;i<avg.Length;i++){
			Console.WriteLine("Day : "+(i+1)+" = "+avg[i]);
		}
		
	}
}