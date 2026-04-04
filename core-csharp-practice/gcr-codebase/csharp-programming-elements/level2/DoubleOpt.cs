using System;

class DoubleOpt{
    static void Main(string[] args){
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double ans1 = a +b*c; 
        double ans2 = a*b+ c;  
        double ans3 = c +a/b; 
        double ans4 = a%b+ c; 

        Console.WriteLine("The results of Double Operations are "
		+ans1+", "+ans2+", "+ans3+", and "+ans4);
    }
}
