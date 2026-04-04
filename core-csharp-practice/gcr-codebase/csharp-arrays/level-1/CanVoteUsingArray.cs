using System;
class CanVoteUsingArray{
	static void Main(string[] args){
		int[] ages=new int[10];//size is given in the question
		
		for(int i=0;i<ages.Length;i++){
			ages[i]=Convert.ToInt32(Console.ReadLine());
		}
		for(int i=0;i<ages.Length;i++){
			if(ages[i]>=18){
				Console.WriteLine("The student with the age "+ages[i]+ " can vote");
			}
            else if(ages[i]<18 && ages[i]>0){
                Console.WriteLine("The student with the age "+ages[i]+" cannot vote");
			}
            else{
                Console.WriteLine("invalid age");
			}
		}			
				

	}
}