using System;
class ReturnChar{
	static void Main(string[] args){
		string str=Console.ReadLine();
		char[] ch=str.ToCharArray();
		Console.WriteLine("using buit-in function :");
		
		for(int i=0;i<str.Length;i++){
			Console.WriteLine(ch[i]);
		}
		Console.WriteLine("using method : ");
		PrintCharacters(str);		
	}
	static void PrintCharacters(string str){
		for(int i=0;i<str.Length;i++){
			Console.WriteLine(str[i]);
		}
	}
}