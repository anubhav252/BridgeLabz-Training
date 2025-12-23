using System;
class PrimeNo{
	static void Main(string[] args){
		int num=int.Parse(Console.ReadLine());
		bool isPrime=true;
		
		if(num>1){
            for(int i=2;i<num;i++){
                if(num%i==0){
                    isPrime= false ;
					break;
				}	
			}
		}	
        if(isPrime){
            Console.WriteLine("prime no.");
		}
        else {
            Console.WriteLine("not a Prime no.");
		}			
	}
}