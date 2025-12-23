using System;
class FindGrade{
	static void Main(string[] args){
		int maths=int.Parse(Console.ReadLine());
		int physics=int.Parse(Console.ReadLine());
		int chemistry=int.Parse(Console.ReadLine());
		int percentage=(maths+physics+chemistry)/3;
		if(percentage>=80){
			Console.WriteLine(percentage+"% secures grade 'A' , remark : (level 4, Above agency-normalized standards)");
		}
		else if(percentage>=70 && percentage<=79){
			Console.WriteLine(percentage+"% secures grade 'B' , remark : (level 3, at agency-normalized standards)");
		}
		else if(percentage>=60 && percentage<=69){
			Console.WriteLine(percentage+"% secures grade 'C' , remark : (level 2, below,but approaching agency-normalized standards)");
		}
		else if(percentage>=50 && percentage<=59){
			Console.WriteLine(percentage+"% secures grade 'D' , remark : (level 1, well below agency-normalized standards)");
		}
		else if(percentage>=40 && percentage<=49){
			Console.WriteLine(percentage+"% secures grade 'E' , remark : (level 1-, too below agency-normalized standards)");
		}
		else if(percentage<=39){
			Console.WriteLine(percentage+"% secures grade 'F' , remark : (Remedial standards)");
		}			
	}
}