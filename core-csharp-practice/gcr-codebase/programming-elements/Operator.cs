using System;
class Operator{
	static void Main(string[] args){
		//Assignment operator such as =,+=,-=,*=,/=
		int a = 5;
		
		//Arithmetic operator such as +,-,*,/
		int n1=5;
		int n2=10;
		 Console.WriteLine(n1+n2);
		 Console.WriteLine(n2-n1);
		 Console.WriteLine(n1*n2);
		 Console.WriteLine(n2/n1);
		 
		 //relational such as >,<,!=,==,<=,>=
		 
		Console.WriteLine(n2>n1);
		Console.WriteLine(n1<n2);
		Console.WriteLine(n1==n2);
		Console.WriteLine(n1!=n2);
		Console.WriteLine(n1<=n2);
		
		//unary such as ++,--
		Console.WriteLine(n1++);
		Console.WriteLine(n1--);
		
		//logical && ,!
		
		bool t=true;
		bool f=false;
		Console.WriteLine(t&&f);
		Console.WriteLine(!t);
		
		//type operator:
        Console.WriteLine(n1 is int);	
	}
}	