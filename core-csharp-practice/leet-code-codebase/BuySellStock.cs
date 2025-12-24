using System;

class BuySellStock{
    static void Main(string[] args){
        int num = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[num];
        for (int i = 0; i < num; i++){
            arr[i] =  Convert.ToInt32(Console.ReadLine());
        }
        int result = MaxProfit(arr);
        Console.WriteLine(result);
    }

    static int MaxProfit(int[] arr){
        int max = 0;

        for (int i = 0;i<arr.Length;i++){
            for (int j = i + 1; j < arr.Length; j++){
                int profit = arr[j] - arr[i];
                if (profit > max)
                {
                    max = profit;
                }
            }
        }
        return max;
    }
}
