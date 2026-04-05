using System;
using TechVilleSmartCity.Infrastructure;
using TechVilleSmartCity.Shared;

namespace TechVilleSmartCity.Domain.Services
{
    public static class CitizenArrayService
    {
        public static void Demo()
        {
            ConsoleHelper.PrintHeader("Citizen ID Operations");

            int[] citizenIds = InMemoryDataStore.CitizenIds;

            Console.WriteLine("Original Citizen IDs:");
            Print(citizenIds);

            Array.Sort(citizenIds);
            Console.WriteLine("Sorted Citizen IDs:");
            Print(citizenIds);

            int searchId = 110;
            int index = Array.BinarySearch(citizenIds, searchId);

            Console.WriteLine(index >= 0
                ? $"Citizen ID {searchId} found at index {index}"
                : "Citizen ID not found");
        }

        private static void Print(int[] array)
        {
            foreach (int id in array)
                Console.Write(id + " ");
            Console.WriteLine("\n");
        }
    }
}
