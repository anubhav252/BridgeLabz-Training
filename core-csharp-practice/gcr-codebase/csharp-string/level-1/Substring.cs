using System;
class Substring{
	static void Main(string[] args){
		string str=Console.ReadLine();
		int startIndex=int.Parse(Console.ReadLine());
		int endIndex=int.Parse(Console.ReadLine());
		string ans1=GetSubstring(str,startIndex,endIndex);
		
		string ans2=str.Substring(startIndex,(endIndex-startIndex));
		Console.WriteLine("using method : "+ ans1);
		Console.WriteLine("using built-in function : "+ans2);
		
		if(ans1.Equals(ans2)){
			Console.WriteLine("got same substring using method and built in function");
		}
		else{
			Console.WriteLine("not same substring");
		}
	}
	static string GetSubstring(string str,int startIndex,int endIndex){
		string result="";
		for(int i=0;i<str.Length;i++){
			if(i>=startIndex && i<endIndex){
				result =result+str[i];
			}
		}
		return result;
	}
}

		