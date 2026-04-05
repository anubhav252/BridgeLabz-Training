using System;
class ReplaceCharacter{
	static void Main(string[] args){
		string str=Console.ReadLine();
		string oldWord=Console.ReadLine();
		string newWord=Console.ReadLine();
		string[] ans=ReplaceWord(str,oldWord,newWord);
		for(int i=0;i<ans.Length;i++){
			Console.Write(ans[i]+" ");
		}
		
		
	}
	static string[] ReplaceWord(string str,string oldWord,string newWord){
		string[] temp=str.Split(' ');
        for(int i=0;i<temp.Length;i++){
            if(temp[i]==oldWord){
                temp[i]=newWord;
			}
		}
		return temp;
	}
}	