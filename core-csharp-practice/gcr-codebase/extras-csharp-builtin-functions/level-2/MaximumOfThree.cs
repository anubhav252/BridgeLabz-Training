using System;
class MaximumOfThree{
    static void Main(string[] args){
        int[] num = TakeInput();
        int maxValue = FindMaximum(num);

        Console.WriteLine("Maximum value is: " + maxValue);
    }

    static int[] TakeInput(){
        int[] nums = new int[3];

        for (int i = 0; i < 3; i++){
            nums[i] = int.Parse(Console.ReadLine());
        }

        return nums;
    }

    static int FindMaximum(int[] num){
        int max = num[0];

        for (int i = 1; i < num.Length; i++){
            if (num[i] > max){
                max = num[i];
            }
        }
        return max;
    }
}
