using System;
class StringAnalyzer{
	static void Main(string[] args){
		GetInput();
	}
	
	static void GetInput(){
		Console.WriteLine("Enter the sentence : ");
		string sentence=Console.ReadLine();
		string[] words=SplitText(sentence);
		Menu(words);
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
	
	static void Menu(string[] words){
		bool start=true;
		while(start){
			
			Console.WriteLine("Enter the no. for you task : \n1. Count number of words \n2. find longest word \n3. replace occurrences \n4. Exit ");
			Console.WriteLine();
			int choice=int.Parse(Console.ReadLine());
	        switch( choice ){
	        	case 1:{
	        		CountWords(words);
	        		break;
	        	}
	        	case 2:{
	        		LongestWord(words);
	        		break;
	        	}
	        	case 3:{
	        		ReplaceOccurrences(words);
	        		break;
	        	}
		    	case 4:{
		    		return;
		    	}
	        	default:{
	        		Console.WriteLine("invalid choice");
	        		break;
	        	}
			}
	    }
	}
	
	static void CountWords(string[] words){
		string punctuations=",.!?;:";
		int count=0;
		for(int i=0;i<words.Length;i++){
			if(!punctuations.Contains(words[i])){
				count++;
			}
		}
		Console.WriteLine("number of words : "+count);
	}
	
	static void LongestWord(string[] words){
        int max=0;
		int idx=0;
        for(int i=0;i<words.Length;i++){
			if(words[i].Length>max){
				max=words[i].Length;
				idx=i;
			}
		}
		Console.WriteLine("longest word : "+words[idx]);	
	}
	
	static void ReplaceOccurrences(string[] words){
		Console.WriteLine("Enter word to be replaced : ");
		string oldWord=Console.ReadLine();
		Console.WriteLine("Enter a new word : ");
		string newWord=Console.ReadLine();
		for(int i=0;i<words.Length;i++){
			if(words[i].ToUpper()==oldWord.ToUpper()){
				words[i]=newWord;
			}
		}
		Console.WriteLine("new sentence : ");
		foreach(string s in words){
			Console.Write(s+" ");
		}
	}
} 		