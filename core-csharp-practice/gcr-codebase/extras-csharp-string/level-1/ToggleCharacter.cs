using System;
class ToggleCharacter{
	static void Main(string[] args){
		string str=Console.ReadLine();
		string ans=Toggle(str);
		Console.WriteLine(ans);
		
	}
	static string Toggle(string ans){
		string temp="";
		for(int i=0;i<ans.Length;i++){
			if((int)ans[i]>=97 && (int)ans[i]<=122){
				temp=temp+ans[i].ToString().ToUpper();
			}
			else{
				temp=temp+ans[i].ToString().ToLower();
			}
		}
		return temp;
	}
}

		
	 