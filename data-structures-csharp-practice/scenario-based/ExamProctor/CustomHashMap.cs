using System;
namespace ExamProctor
{
    class AnswerEntry
    {
        public int QuestionId;
        public string Answer;
        public AnswerEntry Next;

        public AnswerEntry(int id, string ans)
        {
            QuestionId = id;
            Answer = ans;
            Next = null;
        }
    }
    class AnswerHashMap
    {
        private AnswerEntry[] table;
        private int size;

        public AnswerHashMap(int capacity)
        {
            table = new AnswerEntry[capacity];
            size = capacity;
        }

        private int Hash(int key)
        {
            return key % size;
        }

        public void Put(int questionId, string answer)
        {
            int index = Hash(questionId);

            AnswerEntry node = table[index];

            while (node != null)
            {
                if (node.QuestionId == questionId)
                {
                    node.Answer = answer;
                    return;
                }
                node = node.Next;
            }

            AnswerEntry newNode = new AnswerEntry(questionId, answer);
            newNode.Next = table[index];
            table[index] = newNode;
        }

        public string Get(int questionId)
        {
            int index = Hash(questionId);
            AnswerEntry node = table[index];

            while (node != null)
            {
                if (node.QuestionId == questionId)
                    return node.Answer;

                node = node.Next;
            }

            return null;
        }
    }
}