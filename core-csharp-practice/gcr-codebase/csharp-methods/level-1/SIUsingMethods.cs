using System;

class SIUsingMethods{
    static void Main(string[] args){
        double principal = Convert.ToDouble(Console.ReadLine());
        double rate = Convert.ToDouble(Console.ReadLine());
        double time = Convert.ToDouble(Console.ReadLine());

        double si = FindSi(principal,rate,time);

        Console.WriteLine("The Simple Interest is "+si+" for Principal " +principal+", Rate of Interest "+ rate+" and Time "+time);
    }
	internal static double FindSi(double principal,double rate,double time){
		
		double si=(principal* rate* time)/100;
		return si;
	}
}
