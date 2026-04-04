using System;

class Vehicle{
    public static double RegistrationFee = 5000;
    private static int totalVehicles = 0;

    public readonly string RegistrationNumber;
    private string OwnerName;
    private string VehicleType;

    public Vehicle(string RegistrationNumber, string OwnerName, string VehicleType){
        this.RegistrationNumber = RegistrationNumber;
        this.OwnerName = OwnerName;
        this.VehicleType = VehicleType;
        totalVehicles++;
    }

    public static void UpdateRegistrationFee(double newFee){
        if (newFee > 0)
            RegistrationFee = newFee;
    }

    public static void DisplayTotalVehicles(){
        Console.WriteLine("Total Vehicles Registered: " + totalVehicles);
    }

    public void DisplayVehicleDetails() {
        Console.WriteLine("Registration Number : " + RegistrationNumber);
        Console.WriteLine("Owner Name          : " + OwnerName);
        Console.WriteLine("Vehicle Type        : " + VehicleType);
        Console.WriteLine("Registration Fee    : " + RegistrationFee);
        Console.WriteLine("------------------------------");
    }
}

class VehicleRegistrationSystem{
    static void Main(string[] args){
        Vehicle v1 = new Vehicle("MH12AB1234", "Anubhav", "Car");
        Vehicle v2 = new Vehicle("MH14XY5678", "Rohit", "Bike");

        if (v1 is Vehicle){
            v1.DisplayVehicleDetails();
        }

        if (v2 is Vehicle){
            v2.DisplayVehicleDetails();
        }

        Vehicle.UpdateRegistrationFee(6500);

        Console.WriteLine("\nAfter Updating Registration Fee:\n");

        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();

        Vehicle.DisplayTotalVehicles();
    }
}
