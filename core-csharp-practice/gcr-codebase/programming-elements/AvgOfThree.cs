using System;
class AvgOfThree {
    public static void Main(String[] args) {
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2= Convert.ToInt32(Console.ReadLine());
        int n3= Convert.ToInt32(Console.ReadLine());

        double avg = (n1+n2+n3)/3.0;
        Console.WriteLine(avg);
    }
}
