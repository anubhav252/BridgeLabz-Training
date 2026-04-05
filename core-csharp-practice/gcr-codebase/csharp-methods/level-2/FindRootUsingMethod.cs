using System;
class FindRootUsingMethod{
    static void Main(string[] args){
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 0){
            Console.WriteLine("No real roots");
        }
        else if (roots.Length == 1){
            Console.WriteLine("Root : " + roots[0]);
        }
        else{
            Console.WriteLine("Root 1 : " + roots[0]);
            Console.WriteLine("Root 2 : " + roots[1]);
        }
    }

    
    static double[] FindRoots(double a, double b, double c){
        
        double delta = Math.Pow(b, 2) - (4 * a * c);

        
        if (delta < 0){
            return new double[0];
        }

        if (delta == 0){
            double root = -b / (2 * a);
            return new double[] { root };
		}
    
        double sqrtDelta = Math.Sqrt(delta);

        double root1 = (-b + sqrtDelta) / (2 * a);
        double root2 = (-b - sqrtDelta) / (2 * a);

        return new double[] { root1, root2 };
    }
}
