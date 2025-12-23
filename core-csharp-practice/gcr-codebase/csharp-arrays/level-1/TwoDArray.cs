using System;
class TwoDArray{
	static void Main(string[] args){
		int row=int.Parse(Console.ReadLine());
		int col=int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		int[,] arr=new int[row,col];
		int[] ans=new int[row*col];
		for(int i=0;i<row;i++){
			for(int j=0;j<col;j++){
				arr[i,j]=int.Parse(Console.ReadLine());
			}
		}
		int idx=0;
		for(int i=0;i<row;i++){
			for(int j=0;j<col;j++){
				ans[idx]=arr[i,j];
			    idx++;
			}
		}
		Console.WriteLine();
		for(int i=0;i<ans.Length;i++){
			Console.WriteLine(ans[i]);
		}
	}
}