using System;
class Armstrong{
	static void Main(string[] args){
		int num=Convert.ToInt32(Console.ReadLine());
		int temp=num;
		int sum=0;
        while(num!=0){
            int remainder=num%10;
            sum=sum+(int)Math.Pow(remainder,3);
            num=num/10;
        }
        if(temp==sum){
            Console.WriteLine("no. is an Armstrong");
		}	
        else {
            Console.WriteLine("no. is not an Armstrong");
		}			
	}
}