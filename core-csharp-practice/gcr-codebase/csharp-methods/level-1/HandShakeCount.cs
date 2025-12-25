using System;

class HandShakeCount{
    static void Main(string[] args){
        int n = Convert.ToInt32(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("Invalid number of students");
            return;
        }

        int result = CountHandShakes(n);
        Console.WriteLine("total number of handshakes = " + result);
    }
    static int CountHandShakes(int n)
    {
        return (n * (n - 1))/2;
    }
}
