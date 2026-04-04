using System;
class FrequentCharacter{
	static void Main(string[] args){
		string str=Console.ReadLine();
		int ans=CountFrequency(str);
		Console.WriteLine(str[ans]);
	}
	static int CountFrequency(string str){
		int[] arr=new int[str.Length];
		int max=0;
		
		for(int i=0;i<str.Length;i++){
			int count=1;
			for(int j=i+1;j<str.Length;j++){
				if(str[i]==str[j]){
					count++;
				}
			}
			arr[i]=count;
		}
		int idx=0;
		for(int i=0;i<arr.Length;i++){
			if(arr[i]>max){
				max=arr[i];
				idx=i;
			}
		}
		return idx;
	}
}
				
					
		