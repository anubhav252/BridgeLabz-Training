using System;
class NumOp2{
    static void Main(string[] args){
        int number = int.Parse(Console.ReadLine());

        int digitCount = CountDigits(number);
        int[] digits = StoreDigits(number, digitCount);

        Console.WriteLine("Digit Count = " + digitCount);

        Console.WriteLine("Digits:");
        for (int i = 0; i < digits.Length; i++){
            Console.WriteLine(digits[i]);
        }

        Console.WriteLine("Is Duck Number = " + IsDuckNumber(digits));
        Console.WriteLine("Is Armstrong Number = " + IsArmstrongNumber(number, digits));

        int[] largest = FindLargestAndSecondLargest(digits);
        Console.WriteLine("Largest = " + largest[0]);
        Console.WriteLine("Second Largest = " + largest[1]);

        int[] smallest = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine("Smallest = " + smallest[0]);
        Console.WriteLine("Second Smallest = " + smallest[1]);
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

    static bool IsDuckNumber(int[] digits){
        for (int i = 0; i < digits.Length; i++){
            if (digits[i] != 0)
                return true;
        }

        return false;
    }

    static bool IsArmstrongNumber(int number, int[] digits){
        int power = digits.Length;
        int sum = 0;

        for (int i = 0; i < digits.Length; i++){
            sum += (int)Math.Pow(digits[i], power);
        }

        return sum == number;
    }

    static int[] FindLargestAndSecondLargest(int[] digits){
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        for (int i = 0; i < digits.Length; i++){
            if (digits[i] > largest){
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest){
                secondLargest = digits[i];
            }
        }

        return new int[] { largest, secondLargest };
    }

    static int[] FindSmallestAndSecondSmallest(int[] digits){
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        for (int i = 0; i < digits.Length; i++){
            if (digits[i] < smallest){
                secondSmallest = smallest;
                smallest = digits[i];
            }
            else if (digits[i] < secondSmallest && digits[i] != smallest){
                secondSmallest = digits[i];
            }
        }

        return new int[] { smallest, secondSmallest };
    }
}
