using System;
namespace ExamProctor
{
class ExamEvaluator
    {
        public static int EvaluateScore(
            AnswerHashMap answers,
            int[] questionIds,
            string[] correctAnswers)
        {
            int score = 0;

            for (int i = 0; i < questionIds.Length; i++)
            {
                string studentAnswer = answers.Get(questionIds[i]);

                if (studentAnswer != null &&
                    studentAnswer.Equals(correctAnswers[i], StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }
            }

            return score;
        }
    }
}