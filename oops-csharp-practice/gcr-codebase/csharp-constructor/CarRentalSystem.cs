using System;

class CarRental{
    private string customerName;
    private string carModel;
    private int rentalDays;
    private double costPerDay;

    public CarRental(){
        customerName = "Customer";
        carModel = "Standard";
        rentalDays = 1;
        costPerDay = 1000;
    }

    public CarRental(string customerName, string carModel, int rentalDays, double costPerDay){
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
        this.costPerDay = costPerDay;
    }

    public void DisplayDetails(){
        Console.WriteLine("Customer Name : " + customerName);
        Console.WriteLine("Car Model : " + carModel);
        Console.WriteLine("Rental Days : " + rentalDays);
        Console.WriteLine("Total Cost : " + CalculateTotalCost());
    }

    public double CalculateTotalCost(){
        return rentalDays * costPerDay;
    }
}

class CarRentalSystem{
    static void Main(string[] args){
        CarRental rental1 = new CarRental();
		CarRental rental2 = new CarRental("Anubhav", "SUV", 5, 2500);
        rental1.DisplayDetails();
        rental2.DisplayDetails();
    }
}
