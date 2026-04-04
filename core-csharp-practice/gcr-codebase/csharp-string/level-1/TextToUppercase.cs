using System;
class TextToUppercase{
	static void Main(string[] args){
		string str=Console.ReadLine();
		string ans1=str.ToUpper();
		string ans2=ConvertToUppercase(str);
		Console.WriteLine("using built in method : "+ans1);
		Console.WriteLine("using user defined method : "+ans2);
		
		Console.Write("Comparison between both results : ");
		if(ans1.Equals(ans2)){
			Console.Write("both are same ");
		}
		else {
			Console.Write("not same results ");
		}
	}
	static string ConvertToUppercase(string s){
		string result="";
		for(int i=0;i<s.Length;i++){
			int temp=((int)s[i])-32;
			result=result+((char)temp);
		}
		return result;
	}
}