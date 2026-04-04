/*Implement a first in first out (FIFO) queue using only two stacks. The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).

Implement the MyQueue class:

void push(int x) Pushes element x to the back of the queue.
int pop() Removes the element from the front of the queue and returns it.
int peek() Returns the element at the front of the queue.
boolean empty() Returns true if the queue is empty, false otherwise.
Notes:

You must use only standard operations of a stack, which means only push to top, peek/pop from top, size, and is empty operations are valid.
Depending on your language, the stack may not be supported natively. You may simulate a stack using a list or deque (double-ended queue) as long as you use only a stack's standard operations.
 

Example 1:

Input
["MyQueue", "push", "push", "peek", "pop", "empty"]
[[], [1], [2], [], [], []]
Output
[null, null, null, 1, 1, false]
*/

using System;
using System.Collections.Generic;

namespace QueueUsingStack
{
    class MyQueue
    {
        private Stack<int> inputStack;
        private Stack<int> outputStack;

        public MyQueue()
        {
            inputStack = new Stack<int>();
            outputStack = new Stack<int>();
        }

        public void Push(int x)
        {
            inputStack.Push(x);
        }

        public int Pop()
        {
            MoveIfNeeded();
            return outputStack.Pop();
        }

        public int Peek()
        {
            MoveIfNeeded();
            return outputStack.Peek();
        }

        public bool Empty()
        {
            return inputStack.Count == 0 && outputStack.Count == 0;
        }

        private void MoveIfNeeded()
        {
            if (outputStack.Count == 0)
            {
                while (inputStack.Count > 0)
                {
                    outputStack.Push(inputStack.Pop());
                }
            }
        }
    }

    class ProgramMain
    {
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();

            queue.Push(1);
            queue.Push(2);

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Pop());
            Console.WriteLine(queue.Empty());
        }
    }
}
