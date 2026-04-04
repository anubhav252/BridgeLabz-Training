using System;
using System.Collections.Generic;

namespace StockSpanProblem
{
    class Program
    {
        static int[] CalculateStockSpan(int[] prices)
        {
            int n = prices.Length;
            int[] span = new int[n];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
                {
                    stack.Pop();
                }

                span[i] = stack.Count == 0 ? i + 1 : i - stack.Peek();
                stack.Push(i);
            }

            return span;
        }

        static void Main(string[] args)
        {
            int[] prices = { 100, 80, 60, 70, 60, 75, 85 };

            int[] span = CalculateStockSpan(prices);

            for (int i = 0; i < span.Length; i++)
            {
                Console.Write(span[i] + " ");
            }
        }
    }
}
