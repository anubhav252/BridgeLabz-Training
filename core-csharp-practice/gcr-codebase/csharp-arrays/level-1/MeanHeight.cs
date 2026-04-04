using System;
class MeanHeight{
	static void Main(string[] args){
		double[] players=new double[11];
		double sum=0;
		for(int i=0;i<players.Length;i++){
			players[i]=double.Parse(Console.ReadLine());
			sum+=players[i];
		}
		double mean=sum/11;
		Console.WriteLine(mean);
	}
}