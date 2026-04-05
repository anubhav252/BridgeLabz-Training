using System;

namespace CarRentalSystem
{
    interface IRentable {
        double CalculateRent(int days);
    }

    internal class Vehicle:IRentable {
        protected string vehicleType { get; set; }
        protected double vehicleMilage { get; set; }
        public Vehicle(string vehicleType, double vehicleMilage){
            this.vehicleType = vehicleType;
            this.vehicleMilage = vehicleMilage;
        }

        public virtual void DisplayDetails() {
            Console.WriteLine("Vehicle type : "+vehicleType+"\nVehicle Milage : "+vehicleMilage);
        }
        public virtual double CalculateRent(int days) {
            return 0;
        }
    }

    internal class Bike : Vehicle {
        protected int noOfPerson{get;set;}
        protected double costPerDay { get; set; }

        public Bike(string vehicleType,double vehicleMilage,int noOfPerson, double costPerDay):base(vehicleType,vehicleMilage)
        {
            this.noOfPerson = noOfPerson;
            this.costPerDay = costPerDay;
        }

        public override void DisplayDetails() {
            Console.WriteLine("Vehicle type : " + vehicleType + "\nVehicle Milage : " + vehicleMilage +"km/l"+ "\nno of person it can carry : " + noOfPerson + "\nRegistration fee : " + costPerDay);
        }

        public override double CalculateRent(int days)
        {
            return costPerDay * days;
        }
    }

    internal class Car : Vehicle
    {
        protected int noOfPerson { get; set; }
        protected double costPerDay { get; set; }

        public Car(string vehicleType, double vehicleMilage, int noOfPerson, double costPerDay) : base(vehicleType, vehicleMilage)
        {
            this.noOfPerson = noOfPerson;
            this.costPerDay = costPerDay;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Vehicle type : " + vehicleType + "\nVehicle Milage : " + vehicleMilage + " km/l"+"\nno of person it can carry : " + noOfPerson + "\nRegistration fee : " + costPerDay);
        }

        public override double CalculateRent(int days)
        {
            return costPerDay * days;
        }
    }


    internal class Truck : Vehicle
    {
        protected double loadCapacity { get; set; }
        protected double costPerDay { get; set; }

        public Truck(string vehicleType, double vehicleMilage, double loadCapacity, double costPerDay) : base(vehicleType, vehicleMilage)
        {
            this.loadCapacity = loadCapacity;
            this.costPerDay = costPerDay;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Vehicle type : " + vehicleType + "\nVehicle Milage : " + vehicleMilage +" km/l"+"\nLoad Capacity : " + loadCapacity + "\nRegistration fee : " + costPerDay);
        }

        public override double CalculateRent(int days)
        {
            return costPerDay * days;
        }

    }

    internal class Customer{ 
        protected string customerName { get; set; }
        protected int noOfDays { get; set; }

        protected Vehicle vehicle { get; set; }

        public Customer(string customerName, int noOfDays, Vehicle vehicle) { 
            this.customerName = customerName;   
            this.noOfDays = noOfDays;
            this.vehicle = vehicle;
        }

        public void DisplayDetails() {
            Console.WriteLine("Customer Name : "+customerName+"\nNo of days of rent : "+noOfDays);
            vehicle.DisplayDetails();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("total Rent : "+ vehicle.CalculateRent(noOfDays));
            Console.WriteLine("-------------------------------------------");
        }
    }
    internal class VehicleSystem
    {
        static void Main(string[] args) {
            Vehicle v1 = new Bike("bike",30.8,2,350.00);
            Vehicle v2 = new Car("Car", 17.6, 5, 1400.00);
            Vehicle v3 = new Truck("Truck", 9.8,700, 2200.00);

            Customer c1 = new Customer("Anubhav",5,v1);
            Customer c2 = new Customer("sam", 2, v3);
            Customer c3 = new Customer("nick", 7, v2);

            c1.DisplayDetails();
            c2.DisplayDetails();
            c3.DisplayDetails();


        }
    }
}
