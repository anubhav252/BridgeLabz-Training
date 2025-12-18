using System;
class pow {
    public static void Main(String[] args) {
        
        int bas = Convert.ToInt32(Console.ReadLine());
        int pow = Convert.ToInt32(Console.ReadLine());

        double ans = Math.Pow(bas, pow);

        Console.WriteLine(ans);
    }
}
