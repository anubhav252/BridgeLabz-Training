using System;

namespace TechVilleSmartCity.Shared
{
    public static class ConsoleHelper
    {
        public static int ReadInt(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out value))
                    return value;

                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        public static void PrintHeader(string title)
        {
            Console.WriteLine("\n===============================");
            Console.WriteLine(title);
            Console.WriteLine("===============================\n");
        }
    }
}
