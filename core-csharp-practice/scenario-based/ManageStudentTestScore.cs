/*2. Scenario: Develop a program to manage student test scores. The program should:
 ● Store the scores of numberOfStudents students in an array.
 ● Calculate and display the average score.
 ● Find and display the highest and lowest scores.
 ● Identify and display the scores above the average.
 ● Handle invalid input like negative scores or non-numeric input.
 */
 
 
 
 
 using System;
class ManageStudentTestScore{
	static void Main(string[] args){
		GetInput();
	}
	
	static void GetInput(){
	    Console.WriteLine("Enter Number of students");
	    int numberOfStudents = int.Parse(Console.ReadLine());
	    Console.WriteLine("Enter scores of each student");
	    float[] scores = new float[numberOfStudents];
	    for(int i=0;i<numberOfStudents;i++){
	    	scores[i] = float.Parse(Console.ReadLine());
			bool isNonNumeric= 
		    if(scores[i]<0){
				Console.WriteLine("Invalid ");
				i--;
		    }
	    }
        Menu(scores);
	}
	
	static void Menu(float[] scores){
		while(true){
			Console.WriteLine("1. Average Score");
			Console.WriteLine("2. Display Highest and Lowest scores");
			Console.WriteLine("3. Display Scores above Average");
			Console.WriteLine("4. Exit");
			Console.WriteLine();
			
			int chose = int.Parse(Console.ReadLine());
			switch(chose){
				case 1:
					Console.WriteLine("Average Score : " + AverageScore(scores));
					break;
				case 2:
					HighestAndLowest(scores);
					break;
				case 3:
					AboveAverageScores(scores);
					break;
				case 4:
					return;
				default:
					Console.WriteLine("Invalid Choice");
					break;
			}
		}
	}
	
	static float AverageScore(float[] scores){
		float sum =0;
		for(int i=0;i<scores.Length;i++){
			sum += scores[i];
		}
		
		return (sum/scores.Length);
	}
	
	static void AboveAverageScores(float[] scores){
		float avg = AverageScore(scores);
		for(int i=0;i<scores.Length;i++){
			if(scores[i]>avg){
				Console.WriteLine("Student "+ (i+1) + " got : " + scores[i]);
			}
		}
	}
	
	static void HighestAndLowest(float[] scores){
		float highest =0, lowest = int.MaxValue;
		int highestIdx =0, lowestIdx =0;
		for(int i=0;i<scores.Length;i++){
			if(scores[i]>highest){
				highest =scores[i];
				highestIdx = i;
			}
			
			if(scores[i]<lowest){
				lowest= scores[i];
				lowestIdx = i;
			}
		}
		
		Console.WriteLine("Student "+ (highestIdx+1) + " got the Highest Score : " + highest);
		Console.WriteLine("Student "+ (lowestIdx+1) + " got the Lowest Score : " + lowest);
	}
}