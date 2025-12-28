using System;
class SubstringOccurence{
	static void Main(string[] args){
		string str=Console.ReadLine();
		string substring=Console.ReadLine();
		int ans=CountSubstring(str,substring);
		Console.WriteLine(ans);
	}
	static int CountSubstring(string str,string substring){
		int count=0;
		for(int i=0;i<str.Length-substring.Length;i++){
			string temp=str.Substring(i,substring.Length);
			if(temp.Equals(substring)){
				count++;
			}
		}
		return count;
	}
}