using System;
class RemoveSpecificCharacter{
	static void Main(string[] args){
		string str=Console.ReadLine();
		char ch=Convert.ToChar(Console.ReadLine());
		string ans=RemoveCharacter(str,ch);
		Console.WriteLine(ans);
		
	}
	static string RemoveCharacter(string str,char ch){
		string temp="";
		for(int i=0;i<str.Length;i++){
			if(str[i]!=ch){
				temp+=str[i];
			}
		}
		return temp;
	}
}
				