using System;

class TriangularParkRun{
    static void Main(string[] args){
        double s_1 = Convert.ToDouble(Console.ReadLine());
        double s_2 = Convert.ToDouble(Console.ReadLine());
        double s_3 = Convert.ToDouble(Console.ReadLine());

        double rounds = Rounds(s_1, s_2, s_3);

        Console.WriteLine("Number of rounds = " + rounds);
    }
    static double Rounds(double s_1, double s_2, double s_3){
		double dist = 5000; 
        double perimeter = s_1+s_2+s_3;   
        return dist/perimeter;
    }
}
