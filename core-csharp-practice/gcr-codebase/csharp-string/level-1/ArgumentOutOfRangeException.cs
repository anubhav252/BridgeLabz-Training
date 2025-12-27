using System;
class ArgumentOutOfRangeException{
	static void Main(string[] args){
		string str=Console.ReadLine();
		int s_idx=int.Parse(Console.ReadLine());
		int length=int.Parse(Console.ReadLine());
		HandleException(str,s_idx,length);
	}
	static void HandleException(string s,int idx,int end){
		try{
			string ans=s.Substring(idx+s.Length,end);
			Console.WriteLine(ans);
		}
		catch(Exception e){
			Console.WriteLine("Exception : "+e.Message);
		}
	}
}