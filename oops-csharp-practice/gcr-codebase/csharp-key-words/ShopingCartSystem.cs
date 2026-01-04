using System;

class Product{
    public static double Discount = 10.0;

    public readonly int ProductID;
    private string ProductName;
    private double Price;
    private int Quantity;

    public Product(int ProductID, string ProductName, double Price, int Quantity){
        this.ProductID = ProductID;
        this.ProductName = ProductName;
        this.Price = Price;
        this.Quantity = Quantity;
    }

    public static void UpdateDiscount(double newDiscount){
        if (newDiscount >= 0)
            Discount = newDiscount;
    }

    public void DisplayProductDetails(){
        double totalPrice = Price * Quantity;
        double discountedPrice = totalPrice - (totalPrice * Discount / 100);

        Console.WriteLine("Product ID        : " + ProductID);
        Console.WriteLine("Product Name      : " + ProductName);
        Console.WriteLine("Price per Item    : " + Price);
        Console.WriteLine("Quantity          : " + Quantity);
        Console.WriteLine("Discount (%)      : " + Discount);
        Console.WriteLine("Final Price       : " + discountedPrice);
        Console.WriteLine("------------------------------");
    }
}

class ShoppingCartSystem{
    static void Main(string[] args){
        Product p1 = new Product(1, "Laptop", 50000, 1);
        Product p2 = new Product(2, "Headphones", 2000, 2);

        if (p1 is Product){
            p1.DisplayProductDetails();
        }

        if (p2 is Product){
            p2.DisplayProductDetails();
        }

        Product.UpdateDiscount(15);

        Console.WriteLine("After Updating Discount:\n");

        p1.DisplayProductDetails();
        p2.DisplayProductDetails();
    }
}
