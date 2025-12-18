using System;
public class VolCylinder {
    public static void Main(String[] args) {
       
        double rad = Convert.ToDouble(Console.ReadLine());
        double height = Convert.ToDouble(Console.ReadLine());
        double vol = Math.PI * rad*rad * height;
        Console.WriteLine("volume of the cylinder = "+ vol);
    }
    
}
