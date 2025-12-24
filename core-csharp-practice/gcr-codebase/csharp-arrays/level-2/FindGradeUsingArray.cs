using System;
class FindGrade{
	static void Main(string[] args){
		int numOfStudent=int.Parse(Console.ReadLine()); 
		int[] maths=new int[numOfStudent];
		int[] physics=new int[numOfStudent];
		int[] chemistry=new int[numOfStudent];
		double[] percentage=new double[numOfStudent];
		char[] grade=new char[numOfStudent];
		
		for(int i=0;i<numOfStudent;i++){
			Console.WriteLine("enter values for "+(i+1)+" person");
			
			maths[i]=int.Parse(Console.ReadLine());
			physics[i]=int.Parse(Console.ReadLine());
			chemistry[i]=int.Parse(Console.ReadLine());
			
	
			if(maths[i]<0 || physics[i]<0 || chemistry[i]<0){
				Console.WriteLine("invalid no, enter again");
				i--;
			}
		}
		for(int i=0;i<numOfStudent;i++){
			percentage[i]=(maths[i] + physics[i] + chemistry[i])/3.00;
			if(percentage[i]>=80){
				grade[i]='A';
			}
			else if(percentage[i]>=70 && percentage[i]<=79){
				grade[i]='B';
			}
			else if(percentage[i]>=60 && percentage[i]<=69){
				grade[i]='C';
			}
			else if(percentage[i]>=50 && percentage[i]<=59){
				grade[i]='D';
			}
			else if(percentage[i]>=40 && percentage[i]<=49){
				grade[i]='E';
			}
			else {
				grade[i]='R';
			}
		}
		for(int i=0;i<numOfStudent;i++){
			Console.WriteLine("math : "+maths[i]+" physics : "+physics[i]+
			" chemistry : "+chemistry[i]+" percentages : "
			+percentage[i]+" grade : "+grade[i]);
		}			
	}
}