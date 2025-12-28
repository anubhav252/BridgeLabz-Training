using System;
class LongestWord{
	static void Main(string[] args){
		string str=Console.ReadLine();
		string ans=FindLongest(str);
		Console.WriteLine(ans);
	}
	static string FindLongest(string str){
		string[] temp=str.Split(' ');
		int max=0;
		int idx=0;
		for(int i=0;i<temp.Length;i++){
			if(temp[i].Length>max){
			    max=temp[i].Length;
				idx=i;
			}
		}
		return temp[idx];
	}
}