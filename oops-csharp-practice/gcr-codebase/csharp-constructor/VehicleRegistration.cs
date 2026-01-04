using System;

class Vehicle{
    private string ownerName;
    private string vehicleType;

    private static double registrationFee = 5000;

    public Vehicle(string ownerName, string vehicleType){
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    public void DisplayVehicleDetails(){
        Console.WriteLine("Owner Name        : " + ownerName);
        Console.WriteLine("Vehicle Type      : " + vehicleType);
        Console.WriteLine("Registration Fee  : " + registrationFee);
    }

    public static void UpdateRegistrationFee(double newFee){
        registrationFee = newFee;
    }
}

class TestVehicle{
    static void Main(string[] args){
        Vehicle vehicle1 = new Vehicle("Anubhav", "Car");
        Vehicle vehicle2 = new Vehicle("Rohit", "Bike");
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();
        Vehicle.UpdateRegistrationFee(6500);
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();
    }
}
