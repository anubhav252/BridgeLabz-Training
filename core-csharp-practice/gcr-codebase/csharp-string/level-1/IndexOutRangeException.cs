using System;
class IndexOutRangeException{
	static void Main(string[] args){
		string str=Console.ReadLine();
	
		HandleException(str);
		
	}
	static void HandleException(string str){
		try{
			Console.WriteLine(str[str.Length+1]);
		}
		catch(Exception e){
			Console.WriteLine("Exception : "+e.Message);
		}
	}
}