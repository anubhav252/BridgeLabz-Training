using System;
class FindGradeUsingTwoD{
	static void Main(string[] args){
		int numOfStudent=int.Parse(Console.ReadLine()); 
		int[,] marks=new int[numOfStudent,3];
		double[] percentage=new double[numOfStudent];
		char[] grade=new char[numOfStudent];
		
		for(int i=0;i<numOfStudent;i++){
			Console.WriteLine("enter values for "+(i+1)+" person");
			
			for(int j=0;j<3;j++){
				if(j==0){
					marks[i,0]=int.Parse(Console.ReadLine());
				}
				else if(j==1){
					marks[i,1]=int.Parse(Console.ReadLine());
				}
				else if(j==2){
					marks[i,2]=int.Parse(Console.ReadLine());
				}
				
				if(marks[i,0]<0 || marks[i,1]<0 || marks[i,2]<0){
				    Console.WriteLine("invalid no, enter again");
				    i--;
				}
			}
		}	
		
		for(int i=0;i< numOfStudent;i++){
			int sum=0;
			for(int j=0;j<3;j++){
				sum+=marks[i,j];
			}
			percentage[i]=sum/3.00;
			
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
			for(int j=0;j<3;j++){
				if(j==0){
					Console.Write(" math : "+marks[i,0]);
				}
				else if(j==1){
					Console.Write(" physic : "+marks[i,1]);
				}
				else if(j==2){
					Console.Write(" chemistry : "+marks[i,2]);
				}
			}
			
			Console.Write(" percentages : "
			+percentage[i]+" grade : "+grade[i]);
			Console.WriteLine();
		}			
	}
}