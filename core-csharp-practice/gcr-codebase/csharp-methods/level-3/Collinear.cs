using System;
class CollinearPointsChecker{
    static void Main(string[] args){
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        bool slopeResult = AreCollinearUsingSlope(x1, y1, x2, y2, x3, y3);
        bool areaResult = AreCollinearUsingArea(x1, y1, x2, y2, x3, y3);

        Console.WriteLine("Collinear using Slope Method = " + slopeResult);
        Console.WriteLine("Collinear using Area Method = " + areaResult);
    }

    static bool AreCollinearUsingSlope(double x1, double y1,double x2, double y2,double x3, double y3){
        if ((x2 - x1) == 0 || (x3 - x2) == 0 || (x3 - x1) == 0)
            return false;

        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    static bool AreCollinearUsingArea(double x1, double y1,double x2, double y2,double x3, double y3){
        double area = 0.5 * (x1 * (y2 - y3) +x2 * (y3 - y1) +x3 * (y1 - y2));

        return area == 0;
    }
}
