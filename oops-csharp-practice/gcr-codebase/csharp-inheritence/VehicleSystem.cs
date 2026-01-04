using System;

class Vehicle{
    protected int MaxSpeed;
    protected string FuelType;

    public Vehicle(int maxSpeed, string fuelType){
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }

    public virtual void DisplayInfo(){
        Console.WriteLine("Max Speed : " + MaxSpeed + " km/h");
        Console.WriteLine("Fuel Type: " + FuelType);
    }
}

class Car : Vehicle{
    private int SeatCapacity;

    public Car(int maxSpeed, string fuelType, int seatCapacity)
        : base(maxSpeed, fuelType){
        SeatCapacity = seatCapacity;
    }

    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Seat Capacity: " + SeatCapacity);
        Console.WriteLine("--------------------------");
    }
}

class Truck : Vehicle{
    private int PayloadCapacity;

    public Truck(int maxSpeed, string fuelType, int payloadCapacity)
        : base(maxSpeed, fuelType){
        PayloadCapacity = payloadCapacity;
    }

    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Payload Capacity: " + PayloadCapacity + " kg");
        Console.WriteLine("--------------------------");
    }
}

class Motorcycle : Vehicle{
    private bool HasSidecar;

    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
        : base(maxSpeed, fuelType){
        HasSidecar = hasSidecar;
    }

    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Has Sidecar: " + HasSidecar);
        Console.WriteLine("--------------------------");
    }
}

class VehicleSystem{
    static void Main(string[] args){
        Vehicle[] vehicles = new Vehicle[3];

        vehicles[0] = new Car(180, "Petrol", 5);
        vehicles[1] = new Truck(120, "Diesel", 8000);
        vehicles[2] = new Motorcycle(150, "Petrol", false);

        foreach (Vehicle v in vehicles){
            v.DisplayInfo();
        }
    }
}
