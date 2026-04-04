using System;
class FactorsUsingMethod{
	static void Main(string[] args){
		int num=int.Parse(Console.ReadLine());
		int[] factors=FindFactors(num);
		int sum=FindSum(factors);
		double squareSum=FindSumSquare(factors);
		double product=FindProduct(factors);
		Console.Write("Factors : ");
		for(int i=0;i<factors.Length;i++){
			Console.Write(factors[i]+" ");
		}
		Console.WriteLine("\nsum : "+sum);
		Console.WriteLine("sum of square : "+squareSum);
		Console.WriteLine("product : "+product);
	}
	
	static int[] FindFactors(int num){
		int count=0;
		for(int i=1;i<=num/2;i++){
			if(num%i==0){
				count++;
			}
		}
		int[] factors=new int[count];
		int idx=0;
		for(int i=1;i<=num/2;i++){
			if(num%i==0){
				factors[idx]=i;
				idx++;
			}
		}
		return factors;
	}
	
	static int FindSum(int[] factors){
		int sum=0;
		for(int i=0;i<factors.Length;i++){
			sum+=factors[i];
		}
		return sum;
	}
	
	static double FindSumSquare(int[] factors){
		double sum=0;
		for(int i=0;i<factors.Length;i++){
			sum+=Math.Pow(factors[i],2);
		}
		return sum;
	}
	
	static double FindProduct(int[] factors){
		int product=1;
		for(int i=0;i<factors.Length;i++){
			product=product*factors[i];
		}
		return product;
	}
}
	
				