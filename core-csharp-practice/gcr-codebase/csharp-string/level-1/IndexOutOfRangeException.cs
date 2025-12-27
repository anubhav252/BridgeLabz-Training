using System;
class IndexOutOfRangeException{
	static void Main(string[] args){
		int num=int.Parse(Console.ReadLine());
		int[] arr=new int[num];
		for(int i=0;i<num;i++){
			arr[i]=int.Parse(Console.ReadLine());
		}
		HandleException(arr,num);
	}
	
	static void HandleException(int[] arr,int num){
		try{
			Console.WriteLine(arr[num]);
		}
		catch(Exception e){
			Console.WriteLine("Exception : "+e.Message);
		}
	}
}