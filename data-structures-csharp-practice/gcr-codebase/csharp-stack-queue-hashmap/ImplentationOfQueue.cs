using System;
using System.Collections.Generic;

namespace QueueUsingStacks
{
    class StackQueue<T>
    {
        private Stack<T> inputStack = new Stack<T>();
        private Stack<T> outputStack = new Stack<T>();

        public void Enqueue(T item)
        {
            inputStack.Push(item);
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            if (outputStack.Count == 0)
            {
                while (inputStack.Count > 0)
                {
                    outputStack.Push(inputStack.Pop());
                }
            }

            return outputStack.Pop();
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            if (outputStack.Count == 0)
            {
                while (inputStack.Count > 0)
                {
                    outputStack.Push(inputStack.Pop());
                }
            }

            return outputStack.Peek();
        }

        public bool IsEmpty()
        {
            return inputStack.Count == 0 && outputStack.Count == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StackQueue<int> queue = new StackQueue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
