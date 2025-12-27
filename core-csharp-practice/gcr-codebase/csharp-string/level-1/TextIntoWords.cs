using System;
class TextIntoWords{
	static void Main(string[] args){
		string str=Console.ReadLine();
		string[] words=SplitText(str);
		string[,] finalResult=FindLength(words);
		
		Console.WriteLine("words      length");
		for(int i=0;i<words.Length;i++){
			Console.WriteLine(finalResult[i,0]+"          "+finalResult[i,1]);
		}
		
	}

	static string[] SplitText(string str){
		
		int count=0;
		string s=str.Trim();
		for(int i=0;i<s.Length;i++){
			if(s[i]==' '){
				count++;
			}
		}
		string[] arr=new string[count+1];
		int j=0;
		for(int i=0;i<s.Length;i++){
			
			if(s[i]!=' '){
				arr[j]=arr[j]+s[i];
			}
			else if(s[i]==' '){
				j++;
			}
		}
		return arr;
	}
	
	static string[,] FindLength(string[] words){
		string[,] finalResult=new string[words.Length,2];
		for(int i=0;i<words.Length;i++){
			finalResult[i,0]=words[i];
			finalResult[i,1]=words[i].Length.ToString();
		}
		return finalResult;
	}
}
		