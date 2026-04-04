using System;

namespace ParcelTracker
{
    class ParcelTrackerMain
    {
        static void Main(string[] args)
        {
            IParcelTrackerOperations[] utility=new ParcelTrackerUtility[2];
            for(int i=0;i<utility.Length;i++)
            {
                utility[i]=new ParcelTrackerUtility();
                utility[i].AddStage("Order Placed");
                utility[i].AddStage("Shipped"); 
                utility[i].AddStage("In Transit");
                utility[i].AddStage("Out for Delivery");
            }
            Console.WriteLine("Stages for Parcel 1:");
            utility[0].DisplayStages();
            Console.WriteLine("--------------------------");

            utility[1].AddCheckpoint("In Transit", "Reached Sorting Facility");
            Console.WriteLine("Stages for Parcel 2 after adding checkpoint:");
            utility[1].DisplayStages();
            Console.WriteLine("--------------------------");

            utility[1].SimulateLoss("Shipped");
            Console.WriteLine("--------------------------");
            utility[1].DisplayStages();

        }
    }
}