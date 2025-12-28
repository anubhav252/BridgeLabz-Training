using System;
class RemoveDuplicates{
	static void Main(string[] args){
		string str=Console.ReadLine();
		string ans=Remover(str);
		Console.WriteLine(ans);
		
	}
	static string Remover(string str){
		string temp="";
		for(int i=0;i<str.Length;i++){
			if(!temp.Contains(str[i].ToString())){
				temp+=str[i];
			}
		}
		
		return temp;
	}
}
			
			
		