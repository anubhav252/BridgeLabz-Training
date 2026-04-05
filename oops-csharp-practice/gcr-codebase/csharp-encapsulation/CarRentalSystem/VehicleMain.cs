using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    internal class VehicleMain
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles =
            {
                new Car("CAR101", 1500, "CAR-INS-001"),
                new Bike("BIKE201", 500, "BIKE-INS-002"),
                new Truck("TRK301", 3000, "TRK-INS-003")
            };

            int days = 5;

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Display();

                double rentalCost = vehicle.CalculateRentalCost(days);
                double insurance = 0;

                if (vehicle is IInsurable insurable)
                {
                    insurance = insurable.CalculateInsurance();
                    Console.WriteLine(insurable.GetInsuranceDetails());
                }

                Console.WriteLine("Rental Cost (" + days + " days): " + rentalCost);
                Console.WriteLine("Insurance Cost: " + insurance);
                Console.WriteLine("Total Cost: " + (rentalCost + insurance));
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
