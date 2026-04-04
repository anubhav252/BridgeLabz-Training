using System;
namespace ExamProctor
{
    class CustomStack
    {
        public int[] itmes;
        public int top;
        public int capacity;
        public CustomStack(int size)
        {
            itmes = new int[size];
            capacity = size;
            top = -1;
        }
        public void Push(int item)
        {
            if (capacity == 0)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            itmes[++top] = item;
            capacity--;
        }
        public void Pop()
        {
            if (capacity == itmes.Length)
            {
                Console.WriteLine("stack is Empty");
                return;
            }
            Console.WriteLine(itmes[top]);
            top--;
            capacity++;
        }
        public void Peek()
        {
            if (capacity == itmes.Length)
            {
                Console.WriteLine("stack is Empty");
                return;
            }
            Console.WriteLine("last visited ques : " + itmes[top]);

        }
        
    }
}