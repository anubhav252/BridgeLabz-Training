using System;
class DataTypes{
	static void Main(string[] args){
		//premitive data types
		
		int n=5; //integer or numeric value e.g. 2,3
		long l=233124;// for large numeric value 
		float a=5.0f;//float or decimal value e.g. 10.0,5.2
		char ch= 'x';// single character value e.g. 'a','b'
		double d=8.132424;// large decimal values e.g. 5.234235
		bool x= true; // stores true or false
		
	
		// type conversion 
		//implicit 
		
	    int n2=3;
		double d2=n2;
		Console.WriteLine(d2);
		
		//explicit
		double d3=8.234;
		int n3=(int)d3;
		Console.WriteLine(n3);
	}
	
}