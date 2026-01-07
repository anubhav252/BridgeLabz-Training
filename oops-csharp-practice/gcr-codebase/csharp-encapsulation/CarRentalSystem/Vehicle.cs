using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    
        internal abstract class Vehicle
        {
            private string vehicleNumber;
            private string type;
            protected double rentalRate;  

            public string VehicleNumber
            {
                get { return vehicleNumber; }
                set { vehicleNumber = value; }
            }

            public string Type
            {
                get { return type; }
                set { type = value; }
            }

            public double RentalRate
            {
                get { return rentalRate; }
                set
                {
                    if (value > 0)
                        rentalRate = value;
                }
            }

            public Vehicle(string number, string type, double rate)
            {
                VehicleNumber = number;
                Type = type;
                RentalRate = rate;
            }

            public abstract double CalculateRentalCost(int days);

            public virtual void Display()
            {
                Console.WriteLine("Vehicle Number : " + VehicleNumber);
                Console.WriteLine("Vehicle Type   : " + Type);
                Console.WriteLine("Rental Rate    : " + RentalRate);
            }
        }
}
