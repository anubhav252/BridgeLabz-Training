using System;
class StringFormatter{
	static void Main(string[] args){
		GetInput();
	}
	
	
	static void GetInput(){
		string sentence=Console.ReadLine();;
		TrimExtraSpace(sentence);
		
	}
	
	
	static void TrimExtraSpace(string sentence){
		string temp="";
		int left=0;
		int right=0;
		for(int i=0;i<sentence.Length;i++){
			if(sentence[i]!=' '){
				left=i;
				break;
			}
		}
		for(int i=sentence.Length-1;i>=0;i--){
			if(sentence[i]!=' '){
				right=i;
				break;
			}
		}
		for(int i=left;i<=right;i++){
			temp+=sentence[i];
		}
		Console.WriteLine("trimmed :"+temp);
	    ConvertToUpper(temp);	
	}
	
	
	static void ConvertToUpper(string temp){
		string toUpper="";
		int idx=0;
		if(temp[0]>=97 && temp[0]<=123){
			toUpper+=(char)(temp[0]-32);
			idx=1;
		}	
		for(int i=idx;i<temp.Length;i++){
		    if(temp[i]=='.' || temp[i]=='?' || temp[i]== '!'){
				toUpper+=temp[i];
			    if((int)temp[i+1]>=97 && (int)temp[i+1]<=123){
				    toUpper+=(char)(temp[i+1]-32);
					i++;
				}
			}
			else{
				toUpper+=temp[i];
			}
		}
		Console.WriteLine("capitalised Letter :"+toUpper);
		SpaceAfterPunctuation(toUpper);
	}
	
	
	static void SpaceAfterPunctuation(string temp){
		string spacedSentence="";
		string punctuations=",.!?;:";
		for(int i=0;i<temp.Length;i++){
			if(punctuations.Contains(temp[i].ToString())){
				spacedSentence+=temp[i];
				spacedSentence+=' ';
			}
			else{
				spacedSentence+=temp[i];
			}
		}			
		Console.WriteLine("with Space :"+spacedSentence);
	}	
}