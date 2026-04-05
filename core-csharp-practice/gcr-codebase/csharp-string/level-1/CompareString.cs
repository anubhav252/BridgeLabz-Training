using System;
class CompareString{
	static void Main(string[] args){
		string s1=Console.ReadLine();
		string s2=Console.ReadLine();
		
		bool result1=IsEqual(s1,s2);
		bool result2=s1.Equals(s2);
		
		Console.WriteLine("using method : "+result1+"\nusing built-in function "+result2);
	}
	static bool IsEqual(string s1,string s2){
		if(s1.Length==s2.Length){
			for(int i=0;i<s1.Length;i++){
				if(s1[i]!=s2[i]){
					return false;
				}
			}
			return true;		
		}
		return false;
	}
}
		
	