using System;
class WindChill{
	static void Main(string[] args){
		double temp=Convert.ToDouble(Console.ReadLine());
		double windSpeed=Convert.ToDouble(Console.ReadLine());
		WindChill obj=new WindChill();
		
		double windChill= obj.CalculateWindChill(temp,windSpeed);
		Console.WriteLine("Wind Chill : "+windChill);
	}
	public double CalculateWindChill(double temp,double windSpeed){
		double windChill=35.74+0.6215*temp+(0.4275*temp-35.75)*windSpeed*0.16;
		return windChill;
	}
}