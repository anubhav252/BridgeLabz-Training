using System;
class StudentQuizGrader{
	static void Main(string[] args){
		StudentQuizGrader obj=new StudentQuizGrader();
		obj.GetInput();
	}
	
	void GetInput(){
		string[] correctAnswers =
		{
			"New Delhi",
			"C#",
			"Central Processing Unit",
			"Jupiter",
			"Amazon River",
			"Leonardo da Vinci",
			"Pacific Ocean",
			"Oxygen",
			"Microsoft",
			"HTML"
		};
		string[] studentAnswers =
		{
			"new delhi",
			"C#",
			"Central Processing Unit",
			"Mars",
			"Amazon River",
			"Leonardo da Vinci",
			"Pacific ocean",
			"Oxygen",
			"Google",
			"Html"
		};
		/* string[] studentAnswers=new string[correctAnswers.Length];
		for(int i=0;i<studentAnswers.Length;i++){
			studentAnswers[i]=Console.WriteLine();
		} */
		int score=CalculateScore(correctAnswers,studentAnswers);
		Percentage(score);
	}
	
	
	int CalculateScore(string[] correctAnswers,string[] studentAnswers){
		int score=0;
		for(int i=0;i<correctAnswers.Length;i++){
			if(correctAnswers[i].Equals(studentAnswers[i],StringComparison.OrdinalIgnoreCase)){
				Console.WriteLine("Ques "+(i+1)+": correct");
				score++;
			}
			else{
				Console.WriteLine("Ques "+(i+1)+" : incorrect \ncorrect answer is : "+correctAnswers[i]);
			}
		}
		return score;
	}	
	
	void Percentage(int score){
		double percent=(score/10.00)*100.00;
		if(percent<35.00){
			Console.WriteLine("Fail, you got "+percent+"%");
		}
		else{
			Console.WriteLine("Pass, you got "+percent+"%");
		}
	}
}