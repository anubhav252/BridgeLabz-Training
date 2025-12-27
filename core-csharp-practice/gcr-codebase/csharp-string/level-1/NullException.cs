using System;
class NullException{
	static void Main(string[] args){
		string str=null;
		ExceptionHandling(str);
	}
	static void ExceptionHandling(string str){
		try{
			str.ToUpper();
			Console.WriteLine(str);
		}
		catch(NullReferenceException e){
			Console.WriteLine("exception : " +e.Message);
		}
	}
}