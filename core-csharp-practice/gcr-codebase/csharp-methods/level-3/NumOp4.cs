using System;
class NumOp4{
    static void Main(string[] args){
        int number = int.Parse(Console.ReadLine());

        int count = CountDigits(number);
        int[] digits = StoreDigits(number, count);

        int[] reversedDigits = ReverseDigitsArray(digits);

        Console.WriteLine("Digits:");
        for (int i = 0; i < digits.Length; i++){
            Console.WriteLine(digits[i]);
        }

        Console.WriteLine("Reversed Digits:");
        for (int i = 0; i < reversedDigits.Length; i++){
            Console.WriteLine(reversedDigits[i]);
        }

        Console.WriteLine("Arrays Equal = " + CompareArrays(digits, reversedDigits));
        Console.WriteLine("Is Palindrome Number = " + IsPalindrome(digits, reversedDigits));
        Console.WriteLine("Is Duck Number = " + IsDuckNumber(digits));
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

    static int[] ReverseDigitsArray(int[] digits){
        int[] reversed = new int[digits.Length];

        for (int i = 0; i < digits.Length; i++){
            reversed[i] = digits[digits.Length - 1 - i];
        }

        return reversed;
    }

    static bool CompareArrays(int[] array1, int[] array2){
        if (array1.Length != array2.Length)
            return false;

        for (int i = 0; i < array1.Length; i++){
            if (array1[i] != array2[i])
                return false;
        }

        return true;
    }

    static bool IsPalindrome(int[] digits, int[] reversedDigits){
        return CompareArrays(digits, reversedDigits);
    }

    static bool IsDuckNumber(int[] digits){
        for (int i = 0; i < digits.Length; i++){
            if (digits[i] != 0)
                return true;
        }

        return false;
    }
}
