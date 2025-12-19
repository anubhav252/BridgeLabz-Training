using System;

class IntOperation{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        int ans1 = a +b*c; 
        int ans2 = a*b+ c;  
        int ans3 = c +a/b; 
        int ans4 = a%b+ c;  

        Console.WriteLine("The results of Int Operations are "+ans1+
		", "+ans2+", "+ans3+", and "+ans4);
    }
}
