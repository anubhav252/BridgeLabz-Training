using System;
class Trigonometric{
	static void Main(string[] args){
		double angle=Convert.ToDouble(Console.ReadLine());
		
		Trigonometric obj=new Trigonometric();
		double[] results=obj.CalculateTrigonometricFunctions(angle);
		Console.WriteLine("sine = "+ results[0]);
		Console.WriteLine("cosine = "+ results[1]);
		Console.WriteLine("tangent = "+ results[2]);
	}
	public double[] CalculateTrigonometricFunctions(double angle){
		double radian=angle*(3.14/180);
		double sine=Math.Sin(radian);
		double cosine=Math.Cos(radian);
		double tangent=Math.Tan(radian);
		return new double[] {sine,cosine,tangent};
	}
}
		