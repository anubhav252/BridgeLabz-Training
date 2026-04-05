using System;
class Provider{
	public string name_1="rick";// public access modifier : accessed everywhere 
	private string name_2="elsi"; //only in the same class
	protected string name_3="sam";//in the same class , derived class , same project and other project through inheritence
	internal string name_4="steve";//inside the project everywhere,not outside the project
	protected internal string name_5="nick";//same project or derived class 
	//private protected string name_6="marvin";//only when class is derived and is in the same project
}
//derived class
class child : Provider{
	public void show(){
		Console.WriteLine(name_1);
		
		//Console.WriteLine(name_2); X
		
		Console.WriteLine(name_3);
		
		Console.WriteLine(name_4);
		
		Console.WriteLine(name_5);
		
		//Console.WriteLine(name_6); it can be used in derived class but our version is c# 5 and it came from c# 7.2
	}
		
} 
class AccessModifier{
	static void Main(string[] args){
		Provider take=new Provider();
		
		Console.WriteLine(take.name_1);
		
		//Console.WriteLine(take.name_2); X
		
		//Console.WriteLine(take.name_3); X
		
		Console.WriteLine(take.name_4);
		
		Console.WriteLine(take.name_5);
		
		//Console.WriteLine(take.name_6); X
		
	}
}
		
		
		
		