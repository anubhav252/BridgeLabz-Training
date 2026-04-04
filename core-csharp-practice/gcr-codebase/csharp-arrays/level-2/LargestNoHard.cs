using System;
class LargestNo{
	static void Main(string[] args){
		long num=long.Parse(Console.ReadLine());
		long maxDigit=10;
		long[] arr=new long[maxDigit];
		long idx=0;
		
		while(num!=0){
			arr[idx]=num%10;
			num=num/10;
			idx++;
			if(idx==maxDigit){
				maxDigit+=10;
				long[] temp=new long[maxDigit];
				for(int i=0;i<arr.Length;i++){
					temp[i]=arr[i];
				}
				arr=temp;
			}
		}
		long largest=0;
		long secondLargest=0;
		for(int i=0;i<arr.Length;i++){
			if(arr[i]>largest){
				secondLargest=largest;
				largest=arr[i];
			}
			else if(arr[i]>secondLargest && secondLargest!=largest){
				secondLargest=arr[i];
			}
		}
        Console.WriteLine("Largest : "+largest+"\nSecond Largest : "+secondLargest);
		
	}
}