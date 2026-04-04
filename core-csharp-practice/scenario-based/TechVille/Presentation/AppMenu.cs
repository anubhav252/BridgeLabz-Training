using System;
using TechVilleSmartCity.Domain.Services;

namespace TechVilleSmartCity.Presentation
{
    public static class ApplicationMenu
    {
        public static void Show()
        {
            Console.WriteLine("=== TechVille Smart City Management ===");
            Console.WriteLine("1. Smart Citizen Database");
            Console.WriteLine("0. Exit");

            Console.Write("Select option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CitizenArrayService.Demo();
                    ZoneSectorService.Demo();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }
    }
}
