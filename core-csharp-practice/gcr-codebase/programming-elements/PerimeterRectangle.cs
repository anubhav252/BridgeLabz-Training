using System;
class PerimeterRectangle {
    public static void Main(String[] args) {
        
        int leng = Convert.ToInt32(Console.ReadLine());
        int brth = Convert.ToInt32(Console.ReadLine());

        int per = 2*(leng+brth);
        Console.WriteLine(per);
    }
}