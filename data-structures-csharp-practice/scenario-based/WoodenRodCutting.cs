using System;

namespace CustomFurnitureManufacturing
{
    internal class WoodRod
    {
        internal int RodLength = 12;
        internal int[,] PriceChart ={{1, 5},{2, 9},{3, 14},{4, 20},{6, 30}};
    }

    internal class CarpenterUtility
    {
        private WoodRod rod = new WoodRod();
        // Sceanrio A
        public void MaxRevenue()
        {
            int n = rod.RodLength;
            int[] best = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                int max = 0;

                for (int j = 0; j < rod.PriceChart.GetLength(0); j++)
                {
                    int cut = rod.PriceChart[j, 0];
                    int price = rod.PriceChart[j, 1];

                    if (cut <= i)
                    {
                        int revenue = price + best[i - cut];
                        if (revenue > max)
                            max = revenue;
                    }
                }
                best[i] = max;
            }

            Console.WriteLine("Scenario A - Max Revenue: " + best[n]);
        }

        //Scenario B
        public void MaxRevenueWithWaste(int wasteLimit)
        {
            int maxRevenue = 0;

            for (int used = rod.RodLength - wasteLimit; used <= rod.RodLength; used++)
            {
                int[] best = new int[used + 1];

                for (int i = 1; i <= used; i++)
                {
                    int max = 0;

                    for (int j = 0; j < rod.PriceChart.GetLength(0); j++)
                    {
                        int cut = rod.PriceChart[j, 0];
                        int price = rod.PriceChart[j, 1];

                        if (cut <= i)
                        {
                            int revenue = price + best[i - cut];
                            if (revenue > max)
                                max = revenue;
                        }
                    }
                    best[i] = max;
                }

                if (best[used] > maxRevenue)
                    maxRevenue = best[used];
            }

            Console.WriteLine("Scenario B - Max Revenue with Waste Limit: " + maxRevenue);
        }
        // Scenario C

        public void MaxRevenueWithMinWaste()
        {
            int bestRevenue = 0;
            int minWaste = rod.RodLength;

            for (int used = 1; used <= rod.RodLength; used++)
            {
                int[] best = new int[used + 1];

                for (int i = 1; i <= used; i++)
                {
                    int max = 0;

                    for (int j = 0; j < rod.PriceChart.GetLength(0); j++)
                    {
                        int cut = rod.PriceChart[j, 0];
                        int price = rod.PriceChart[j, 1];

                        if (cut <= i)
                        {
                            int revenue = price + best[i - cut];
                            if (revenue > max)
                                max = revenue;
                        }
                    }
                    best[i] = max;
                }

                int waste = rod.RodLength - used;

                if (best[used] > bestRevenue ||
                   (best[used] == bestRevenue && waste < minWaste))
                {
                    bestRevenue = best[used];
                    minWaste = waste;
                }
            }

            Console.WriteLine("Scenario C - Best Revenue: " + bestRevenue);
            Console.WriteLine("Scenario C - Minimum Waste: " + minWaste);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CarpenterUtility utility = new CarpenterUtility();

            utility.MaxRevenue();
            Console.WriteLine("----------------");

            utility.MaxRevenueWithWaste(2);
            Console.WriteLine("----------------");

            utility.MaxRevenueWithMinWaste();
        }
    }
}
