using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideHaillingSystem
{
    interface IGps
    {
        string GetCurrentLocation();
        void UpdateLocation(string newLocation);
    }

    abstract class Vehicle
    {
        private int vehicleId;
        private string driverName;
        private double ratePerKm;
        private string currentLocation;

        public int VehicleId
        {
            get { return vehicleId; }
            protected set { vehicleId = value; }
        }

        public string DriverName
        {
            get { return driverName; }
            protected set { driverName = value; }
        }

        public double RatePerKm
        {
            get { return ratePerKm; }
            protected set
            {
                if (value > 0)
                {
                    ratePerKm = value;
                }
            }
        }

        protected string CurrentLocation
        {
            get { return currentLocation; }
            set { currentLocation = value; }
        }

        protected Vehicle(int id, string driver, double rate)
        {
            VehicleId = id;
            DriverName = driver;
            RatePerKm = rate;
            CurrentLocation = "Unknown";
        }

        public abstract double CalculateFare(double distance);

        public void GetVehicleDetails()
        {
            Console.WriteLine("Vehicle Id  : " + VehicleId);
            Console.WriteLine("Driver Name : " + DriverName);
            Console.WriteLine("Rate/Km     : " + RatePerKm);
            Console.WriteLine("Location    : " + CurrentLocation);
        }
    }

    class Car : Vehicle, IGps
    {
        public Car(int id, string driver, double rate) : base(id, driver, rate) { }

        public override double CalculateFare(double distance)
        {
            return (RatePerKm * distance) + 50;
        }

        public string GetCurrentLocation()
        {
            return CurrentLocation;
        }

        public void UpdateLocation(string newLocation)
        {
            CurrentLocation = newLocation;
        }
    }

    class Bike : Vehicle, IGps
    {
        public Bike(int id, string driver, double rate) : base(id, driver, rate) { }

        public override double CalculateFare(double distance)
        {
            return RatePerKm * distance;
        }

        public string GetCurrentLocation()
        {
            return CurrentLocation;
        }

        public void UpdateLocation(string newLocation)
        {
            CurrentLocation = newLocation;
        }
    }

    class Auto : Vehicle, IGps
    {
        public Auto(int id, string driver, double rate) : base(id, driver, rate) { }

        public override double CalculateFare(double distance)
        {
            return (RatePerKm * distance) + 20;
        }

        public string GetCurrentLocation()
        {
            return CurrentLocation;
        }

        public void UpdateLocation(string newLocation)
        {
            CurrentLocation = newLocation;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] fleet = {new Car(101, "Arjun", 15),new Bike(102, "Neha", 8),new Auto(103, "Ramesh", 10)};

            double tripDistance = 12.5;

            foreach (Vehicle vehicle in fleet)
            {
                if (vehicle is IGps gps)
                {
                    gps.UpdateLocation("City Center");
                }

                vehicle.GetVehicleDetails();
                Console.WriteLine("Fare for " + tripDistance + " km : " +vehicle.CalculateFare(tripDistance));
                Console.WriteLine("----------------------------");
            }
        }
    }
}
