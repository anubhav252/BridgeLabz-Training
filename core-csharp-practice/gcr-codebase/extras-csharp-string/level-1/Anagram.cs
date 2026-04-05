using System;
class Anagram{
	static void Main(string[] args){
		string str1=Console.ReadLine();
		string str2=Console.ReadLine();
		bool isAnagram=IsAnagram(str1,str2);
		Console.WriteLine((isAnagram==true?"is anagram":"not a anagram"));
		
	}
	static bool IsAnagram(string str1,string str2){
		string s1=str1.Trim();
		string s2=str2.Trim();
		if(s1.Length!=s2.Length){
			return false;
		}
		
		for(int i=0;i<s1.Length;i++){
			if(!s1.Contains(s2[i].ToString())){
				return false;
			}
		}
		return true;
	}
}
			