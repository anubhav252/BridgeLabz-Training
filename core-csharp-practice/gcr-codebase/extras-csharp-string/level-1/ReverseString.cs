using System;
class ReverseString{
	static void Main(string[] args){
		string str=Console.ReadLine();
		string ans = Reverse(str);
		Console.WriteLine(ans);
	}
	static string Reverse(string str){
		string ans="";
		for(int i=str.Length-1;i>=0;i--){
			ans=ans+str[i];
		}
		return ans;
	}
}
			