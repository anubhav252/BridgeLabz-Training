using System;
class CountVowelsAndConsonants{
	static void Main(string[] args){
		string word=Console.ReadLine();
		int[] result=Counter(word);
		
		for(int i=0;i<result.Length;i++){
			if(i==0) Console.WriteLine("vowel : "+result[i]);
				
			else Console.WriteLine("consonant : "+result[i]);
		}
	}
	
	static int[] Counter(string word){
		string vowel="aeiou";
		int[] count=new int[2];  // at 0 index we will store vowel count and at 1 index consonent
		int vowelCount=0;
		int consonentCount=0;
		for(int i=0;i<word.Length;i++){
			if(vowel.Contains(word[i].ToString())){
				count[0]=++vowelCount;
			}
			else 
				count[1]=++consonentCount;
			
	
		}
		return count;
	}
}