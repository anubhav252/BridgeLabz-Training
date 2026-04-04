using TechVilleSmartCity.Shared;

namespace TechVilleSmartCity.Infrastructure
{
    public static class InMemoryDataStore
    {
        // Stores citizen IDs (1D array)
        public static int[] CitizenIds =
        {
            105, 102, 110, 101, 108
        };

        // Stores zone-sector citizen count (2D array)
        public static int[,] ZoneSectorCitizens =
        {
            {120, 98, 110, 90},
            {150, 130, 125, 140},
            {80, 75, 95, 100},
            {200, 180, 170, 160},
            {60, 70, 65, 55}
        };
    }
}
