using System;
namespace OceanFleet
{
    class VessalUtil
    {
        private List<Vessal> vessalList=new List<Vessal>();
        public void AddVessalPerformance(Vessal vessal)
        {
            vessalList.Add(vessal);
        }

        public Vessal GetVessalById(string vessalId)
        {
            foreach(var vessal in vessalList)
            {
                if (vessal.VessalId.Equals(vessalId))
                {
                    return vessal;
                }
            }
            return null;
        }

        public List<Vessal> GetHighPerformanceVessels()
        {
            List<Vessal> highPerformanceVessel=new List<Vessal>();
            double maxSpeed=0;
            foreach(var vessal in vessalList)
            {
                if (vessal.AverageSpeed >= maxSpeed)
                {
                    maxSpeed=vessal.AverageSpeed;
                    highPerformanceVessel.Add(vessal);
                }
            }
            return highPerformanceVessel;
        }
    }
}