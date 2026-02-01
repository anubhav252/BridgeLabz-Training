using System;
using System.Text.RegularExpressions;
namespace OceanFleet
{
    class UserInterface
    {
        static void Main(string[] args)
        {
            VessalUtil obj=new VessalUtil();
            System.Console.WriteLine("Enter the number of vessels to be added");
            int numberOfVessel=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter vessel details");
            for(int i = 0; i < numberOfVessel; i++)
            {
                string userInput=Console.ReadLine();
                string pattern=@"[:]";
                string[] splittedInput=Regex.Split(userInput,pattern);
                Vessal vessal=new Vessal(splittedInput[0],splittedInput[1],double.Parse(splittedInput[2]),splittedInput[3]);
                obj.AddVessalPerformance(vessal);
            }

            System.Console.WriteLine("Enter the vessel Id to check speed");
            string vessalId=Console.ReadLine();
            Vessal vessalById=obj.GetVessalById(vessalId);
            System.Console.WriteLine($"{vessalById.VessalId} | {vessalById.VessalName} | {vessalById.VessalType} | {vessalById.AverageSpeed}knots");
            
            System.Console.WriteLine("High performance vessels are");
            var highPerformanceVessel=obj.GetHighPerformanceVessels();
            foreach(var vessal in highPerformanceVessel)
            {
                System.Console.WriteLine($"{vessal.VessalId} | {vessal.VessalName} | {vessal.VessalType} | {vessal.AverageSpeed}konts");
            }
            System.Console.WriteLine();

        }
    }
}