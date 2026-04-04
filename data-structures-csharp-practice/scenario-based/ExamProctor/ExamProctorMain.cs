using System;
namespace ExamProctor{
    class ExamProctorMain
    {
        static void Main(string[] args)
        {
            CustomStack navigation = new CustomStack(20);
            AnswerHashMap answers = new AnswerHashMap(10);

            int[] questionIds = { 101, 102, 103, 104 };
            string[] correctAnswers = { "A", "C", "B", "D" };

            navigation.Push(101);
            navigation.Push(102);
            navigation.Push(103);

            answers.Put(101, "A");
            answers.Put(102, "C");
            answers.Put(103, "B");
            answers.Put(104, "A");

            navigation.Peek();

            int score = ExamEvaluator.EvaluateScore(
                answers,
                questionIds,
                correctAnswers);

            Console.WriteLine("Final Score: " + score + "/" + questionIds.Length);
        }
    }
}  