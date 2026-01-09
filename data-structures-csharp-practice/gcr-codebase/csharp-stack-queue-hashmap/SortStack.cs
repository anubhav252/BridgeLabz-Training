using System;
using System.Collections.Generic;

namespace SortStackUsingRecursion
{
    class StackSorter
    {
        public static void SortStack(Stack<int> stack)
        {
            if (stack.Count == 0)
                return;

            int top = stack.Pop();
            SortStack(stack);
            InsertInSortedOrder(stack, top);
        }

        private static void InsertInSortedOrder(Stack<int> stack, int value)
        {
            if (stack.Count == 0 || stack.Peek() <= value)
            {
                stack.Push(value);
                return;
            }

            int temp = stack.Pop();
            InsertInSortedOrder(stack, value);
            stack.Push(temp);
        }
    }

    class ProgramMain
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(3);
            stack.Push(1);
            stack.Push(4);
            stack.Push(2);

            StackSorter.SortStack(stack);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
