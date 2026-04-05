using System;

namespace TechVilleSmartCity.Domain.Services
{
    public static class ZoneSectorService
    {
        public static void Demo()
        {
            int[,] zoneSectorCitizens =
            {
                {120, 98, 110, 90},
                {150, 130, 125, 140},
                {80, 75, 95, 100},
                {200, 180, 170, 160},
                {60, 70, 65, 55}
            };

            Console.WriteLine("\nZone-Sector Citizen Data:");

            for (int zone = 0; zone < zoneSectorCitizens.GetLength(0); zone++)
            {
                Console.WriteLine($"Zone {zone + 1}:");
                for (int sector = 0; sector < zoneSectorCitizens.GetLength(1); sector++)
                {
                    Console.WriteLine($"  Sector {sector + 1} → {zoneSectorCitizens[zone, sector]} citizens");
                }
            }
        }
    }
}
