using System;
class NumOp3{
    static void Main(string[] args){
        int number = int.Parse(Console.ReadLine());

        int digitCount = CountDigits(number);
        int[] digits = StoreDigits(number, digitCount);

        Console.WriteLine("Digit Count = " + digitCount);

        Console.WriteLine("Digits:");
        for (int i = 0; i < digits.Length; i++){
            Console.WriteLine(digits[i]);
        }

        int sumOfDigits = FindSumOfDigits(digits);
        Console.WriteLine("Sum of Digits = " + sumOfDigits);

        int sumOfSquares = FindSumOfSquaresOfDigits(digits);
        Console.WriteLine("Sum of Squares of Digits = " + sumOfSquares);

        Console.WriteLine("Is Harshad Number = " + IsHarshadNumber(number, digits));

        int[,] frequency = FindDigitFrequency(digits);

        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < frequency.GetLength(0); i++){
            if (frequency[i, 1] > 0){
                Console.WriteLine(frequency[i, 0] + " -> " + frequency[i, 1]);
            }
        }
    }

    static int CountDigits(int number){
        if (number == 0)
            return 1;

        int count = 0;
        int temp = Math.Abs(number);

        while (temp > 0){
            count++;
            temp /= 10;
        }

        return count;
    }

    static int[] StoreDigits(int number, int count){
        int[] digits = new int[count];
        int temp = Math.Abs(number);

        for (int i = count - 1; i >= 0; i--){
            digits[i] = temp % 10;
            temp /= 10;
        }

        return digits;
    }

    static int FindSumOfDigits(int[] digits){
        int sum = 0;

        for (int i = 0; i < digits.Length; i++){
            sum += digits[i];
        }

        return sum;
    }

    static int FindSumOfSquaresOfDigits(int[] digits){
        int sum = 0;

        for (int i = 0; i < digits.Length; i++){
            sum += (int)Math.Pow(digits[i], 2);
        }

        return sum;
    }

    static bool IsHarshadNumber(int number, int[] digits){
        int sum = FindSumOfDigits(digits);

        if (sum == 0)
            return false;

        return number % sum == 0;
    }

    static int[,] FindDigitFrequency(int[] digits){
        int[,] frequency = new int[10, 2];

        for (int i = 0; i < 10; i++){
            frequency[i, 0] = i;
            frequency[i, 1] = 0;
        }

        for (int i = 0; i < digits.Length; i++){
            frequency[digits[i], 1]++;
        }

        return frequency;
    }
}
