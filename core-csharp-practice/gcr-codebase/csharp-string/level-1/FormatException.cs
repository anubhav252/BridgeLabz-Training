using System;
class FormatException{
	static void Main(string[] args){
		string str=Console.ReadLine();
		HandleException(str);
	}
	static void HandleException(string s){
		
		try{
			int ans=int.Parse(s);
			Console.WriteLine(ans);
		}
		catch(Exception e){
			Console.WriteLine(" Exception : "+e.Message);
		}
	}
}
