using System;
public class SimpleInterest {
    public static void Main(String[] args) {
       
        int p = Convert.ToInt32(Console.ReadLine());
        int rt = Convert.ToInt32(Console.ReadLine());
        int time = Convert.ToInt32(Console.ReadLine());
        int sI = (p * rt * time) / 100;
        Console.WriteLine("Simple Interest = " + sI);
    }
}