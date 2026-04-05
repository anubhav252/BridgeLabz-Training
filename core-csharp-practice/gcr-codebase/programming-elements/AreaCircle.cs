using System;
public class AreaCircle {
    public static void Main(String[] args) {
        float rad = float.Parse(Console.ReadLine());
        float pi=3.14f;
        float area = pi * rad * rad;
        Console.WriteLine("Area of the circle = " + area);
    }
}
