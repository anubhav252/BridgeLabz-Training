using System;
class DistributeChocolateUsingMethod{
    static void Main(string[] args){
        int numOfChocolates = int.Parse(Console.ReadLine());
        int numOfChildren = int.Parse(Console.ReadLine());

        if (numOfChildren == 0)
        {
            Console.WriteLine("invalid");
            return;
        }
        int[] result = ChocolatesPerChild(numOfChocolates, numOfChildren);
        Console.WriteLine("Each child gets = " + result[0]);
        Console.WriteLine("Remaining chocolates = " + result[1]);
    }

    public static int[] ChocolatesPerChild(int numOfChocolates, int numOfChildren)
    {
        int chocolatesPerChild = numOfChocolates / numOfChildren;
        int remaining = numOfChocolates % numOfChildren;

        return new int[] { chocolatesPerChild, remaining };
    }
}
