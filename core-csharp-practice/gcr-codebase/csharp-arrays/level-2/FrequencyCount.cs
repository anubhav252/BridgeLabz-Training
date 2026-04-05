using System;
class FrequencyCount{
	static void Main(string[] args){
		int num=int.Parse(Console.ReadLine());
		int count=0;
		int temp1=num;
		
		while(temp1!=0){
			temp1=temp1/10;
			count++;
		}
		
		int[] digits=new int[count];
		int[] frequency=new int[10];
		
		for(int i=0;i<count;i++){
			digits[i]=num%10;
			num=num/10;
		}
	
		 for (int i =0;i <count;i++){
            int temp2 = digits[i];
            frequency[temp2]++;
        }
		Console.WriteLine("Digits  :   Frequency" );
        for (int i= 0; i<10;i++){
            if (frequency[i]> 0)
                Console.WriteLine("   "+i+"    =      "+frequency[i]);
			else{
				Console.WriteLine("   "+i+"    =      "+frequency[i]);
			}
        }
		
		
		
	}
}