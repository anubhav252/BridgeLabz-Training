using System;
class FibonacciSequence{
    static void Main(string[] args){
        int num = int.Parse(Console.ReadLine());
        GenerateFibonacci(num);
    }

    static void GenerateFibonacci(int num){
        if (num <= 0)
            return;

        int first = 0;
        int second = 1;

        if (num >= 1)
            Console.Write(first);

        if (num >= 2)
            Console.Write(" " + second);

        for (int i = 3; i <= num; i++){
            int next = first + second;
            Console.Write(" " + next);
            first = second;
            second = next;
        }
    }
}
