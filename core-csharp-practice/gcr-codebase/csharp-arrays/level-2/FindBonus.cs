using System;
class FindBonus{
	static void Main(string[] args){
		double[] oldSalary=new double[10];
		double[] years=new double[10];
		double[] bonus=new double[10];
		double[] newSalary=new double[10];
		double totalBonus=0;
		double totalOldSalary=0;
		double totalnewSalary=0;
		Console.WriteLine("Enter salary : ");
		for(int i=0;i<10;i++){
			oldSalary[i]=int.Parse(Console.ReadLine());
			if(oldSalary[i]<=0){
				Console.WriteLine("Invalid number , Enter again : ");
				i--;
			}
			else{
				totalOldSalary+=oldSalary[i];
			}
		}
		Console.WriteLine("Enter year of service : ");
		for(int i=0;i<years.Length;i++){
			years[i]=int.Parse(Console.ReadLine());
			if(years[i]<=0){
				Console.WriteLine("Invalid number , Enter again : ");
				i--;
			}
			else{
				if(years[i]>5){
					bonus[i]=0.05*oldSalary[i];
				    totalBonus+=bonus[i];
				    newSalary[i]=bonus[i]+oldSalary[i];
				    totalnewSalary+=newSalary[i];
				
			    }
			    else{
				    bonus[i]=0.02*oldSalary[i];
				    totalBonus+=bonus[i];
				    newSalary[i]=bonus[i]+oldSalary[i];
				    totalnewSalary+=newSalary[i];
			    }
			}
			
		}
		Console.WriteLine("total bonus : "+ totalBonus+
		"\ntotalnewSalary : " +totalnewSalary+"\n totalOldSalary : "+totalOldSalary);
	}
}