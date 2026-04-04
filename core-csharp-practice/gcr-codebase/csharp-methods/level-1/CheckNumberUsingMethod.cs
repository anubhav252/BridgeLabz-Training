using System;

class CheckNumber{
    static void Main(string[] args){
        int num = int.Parse(Console.ReadLine());

        int result = CheckNum(num);

        if (result == 1)
            Console.WriteLine("number is Positive");
        else if (result == -1)
            Console.WriteLine("number is Negative");
        else
            Console.WriteLine("number is Zero");
    }
    static int CheckNum(int num){
        if (num > 0)
            return 1;
        else if (num < 0)
            return -1;
        else
            return 0;
    }
}
