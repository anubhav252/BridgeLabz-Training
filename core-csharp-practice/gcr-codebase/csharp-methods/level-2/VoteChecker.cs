using System;
class VoteChecker{
    static void Main(string[] args){
        int[] ages = new int[10];
		for (int i = 0; i < ages.Length; i++){
            ages[i] = int.Parse(Console.ReadLine());
		}
        for (int i = 0; i < ages.Length; i++){
            bool canVote = Checker(ages[i]);
            if (canVote)
                Console.WriteLine("Student " + (i + 1) + " can vote");
            else
                Console.WriteLine("Student " + (i + 1) + " cannot vote");
        }
    }

    static bool Checker(int age){
        if (age < 0){
            return false;
		}
        if (age >= 18){
            return true;
		}
        return false;
    }
}
