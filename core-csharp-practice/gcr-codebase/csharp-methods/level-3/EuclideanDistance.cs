using System;
class EuclideanDistance{
    static void Main(string[] args){
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double distance = FindDistance(x1, y1, x2, y2);
        Console.WriteLine("Distance = " + distance);

        double[] line = FindLineEquation(x1, y1, x2, y2);

        if (double.IsNaN(line[0])){
            Console.WriteLine("Line is vertical (slope undefined)");
        }
        else{
            Console.WriteLine("Slope (m) = " + line[0]);
            Console.WriteLine("Y-Intercept (b) = " + line[1]);
            Console.WriteLine("Equation: y = " + line[0] + "x + " + line[1]);
        }
    }

    static double FindDistance(double x1, double y1, double x2, double y2){
        return Math.Sqrt(
            Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)
        );
    }

    static double[] FindLineEquation(double x1, double y1, double x2, double y2){
        if (x2 == x1){
            return new double[] { double.NaN, double.NaN };
		}

        double m = (y2 - y1) / (x2 - x1);
        double b = y1 - m * x1;

        return new double[] { m, b };
    }
}
