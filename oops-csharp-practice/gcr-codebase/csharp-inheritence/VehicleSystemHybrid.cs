using System;
interface Refuelable{
    void Refuel();
}

class Vehicle{
    protected int MaxSpeed;
    protected string Model;

    public Vehicle(int maxSpeed, string model){
        MaxSpeed = maxSpeed;
        Model = model;
    }

    public void DisplayVehicleInfo()
    {
        Console.WriteLine("Model     : " + Model);
        Console.WriteLine("Max Speed : " + MaxSpeed + " km/h");
    }
}

class ElectricVehicle : Vehicle{
    public ElectricVehicle(int maxSpeed, string model)
        : base(maxSpeed, model) { }

    public void Charge(){
        Console.WriteLine("Charging the electric vehicle");
    }

    public void DisplayDetails(){
        Console.WriteLine("Vehicle Type : Electric Vehicle");
        DisplayVehicleInfo();
        Charge();
        Console.WriteLine("--------------------------");
    }
}

class PetrolVehicle : Vehicle, Refuelable{
    public PetrolVehicle(int maxSpeed, string model)
        : base(maxSpeed, model) { }

    public void Refuel(){
        Console.WriteLine("Refueling the petrol vehicle");
    }

    public void DisplayDetails(){
        Console.WriteLine("Vehicle Type : Petrol Vehicle");
        DisplayVehicleInfo();
        Refuel();
        Console.WriteLine("--------------------------");
    }
}

class VehicleSystem{
    static void Main(string[] args){
        ElectricVehicle ev = new ElectricVehicle(160, "Tesla Model 3");
        PetrolVehicle pv = new PetrolVehicle(180, "Honda City");

        ev.DisplayDetails();
        pv.DisplayDetails();
    }
}
