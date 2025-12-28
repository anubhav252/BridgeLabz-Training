using System;
class Pallindrom{
	static void Main(string[] args){
		string str=Console.ReadLine();
		bool ans=IsPallindrom(str);
		Console.WriteLine((ans==true)?"it is pallindrom" : "not a pallindrom");
	}
	
	static bool IsPallindrom(string str){
		string reverse="";
		for(int i=str.Length-1;i>=0;i--){
			reverse=reverse+str[i];
		}
		if(reverse==str){
			return true;
		}
		return false;
	}
}