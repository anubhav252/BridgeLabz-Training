using System;
class NumOpUsingMethod{
    static void Main(string[] args){
        int[] num = new int[5];
        for (int i = 0; i < num.Length; i++){
            num[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < num.Length; i++){
            if (IsPositive(num[i])){
                Console.Write("Number " + num[i] + " is Positive and ");

                if (IsEven(num[i]))
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");
            }
            else{
                Console.WriteLine("Number " + num[i] + " is Negative");
            }
        }

        int compareResult = Compare(num[0], num[num.Length - 1]);

        if (compareResult == 1)
            Console.WriteLine("First  is Greater than ");
        else if (compareResult == 0)
            Console.WriteLine("First  is Equal to last ");
        else
            Console.WriteLine("First  is Less than last ");
    }

    static bool IsPositive(int num){
        return num >= 0;
    }

    static bool IsEven(int num){
        return num % 2 == 0;
    }

    public static int Compare(int num1, int num2){
        if (num1 > num2)
            return 1;
        else if (num1 == num2)
            return 0;
        else
            return -1;
    }
}
