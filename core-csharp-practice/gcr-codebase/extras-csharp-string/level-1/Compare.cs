using System;
class Compare{
	static void Main(string[] args){
		string str1=Console.ReadLine();
		string str2=Console.ReadLine();
		CompareStrings(str1,str2);
	}
	static void CompareStrings(string str1,string str2){
		string first="";
		string second="";
		if(str1.Contains(str2) || str2.Contains(str1)){
			Console.WriteLine((str1.Length<str2.Length)?
			str1 +" comes before "+str2 +" in lexicographical order":
			str2 +" comes before "+str1 +" in lexicographical order");
		}
		else{
			for(int i=0;i<Math.Min(str1.Length,str2.Length);i++){
				if(str1[i]!=str2[i]){
					if((int)str1[i]<(int)str2[i]){
						first+=str1;
						second+=str2;
					}
					else{
						first+=str2;
						second+=str1;
					}
					break;
				}
			}
			Console.WriteLine(first +" comes before "+second +" in lexicographical order");
		}
	}
}