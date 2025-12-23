using System;
class SumTillZero{
	static void Main(string[] args){
		double[] num=new double[10];
		double total=0;
		int i=0;
		while(true){
			
			double temp=double.Parse(Console.ReadLine());
			if(temp==0 || temp <0){
				break;
			}
			else{
				num[i]=temp;
				total+=num[i];
			}
			i++;
			if(i==10){
				break;
			}
		}
		Console.WriteLine(total);
		
	}
}