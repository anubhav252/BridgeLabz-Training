using System;
public class CelsiusConversion {
    public static void Main(String[] args) {
        float cels = Convert.ToSingle(Console.ReadLine());
        float fahren = (cels * 9/5) + 32;
        Console.WriteLine(cels + "°C is = " + fahren + "°F");
    }
}
