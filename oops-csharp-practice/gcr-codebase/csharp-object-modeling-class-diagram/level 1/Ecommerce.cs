using System;
using System.Collections.Generic;

class Product{
    public string ProductName;
    public double Price;

    public Product(string productName, double price)
    {
        ProductName = productName;
        Price = price;
    }
}

class Order{
    public int OrderId;
    private List<Product> products;

    public Order(int orderId){
        OrderId = orderId;
        products = new List<Product>();
    }

    public void AddProduct(Product product){
        products.Add(product);
    }

    public void DisplayOrderDetails(){
        Console.WriteLine("Order ID: " + OrderId);
        double total = 0;

        foreach (Product p in products)
        {
            Console.WriteLine("Product: " + p.ProductName + " | Price: " + p.Price);
            total += p.Price;
        }

        Console.WriteLine("Total Order Amount: " + total);
        Console.WriteLine("----------------------------");
    }
}

class Customer{
    public string CustomerName;
    private List<Order> orders;

    public Customer(string customerName){
        CustomerName = customerName;
        orders = new List<Order>();
    }

    public void PlaceOrder(Order order){
        orders.Add(order);
        Console.WriteLine(CustomerName + " placed Order ID: " + order.OrderId);
    }

    public void ViewOrders()
    {
        Console.WriteLine("\nOrders placed by " + CustomerName + ":");
        foreach (Order order in orders)
        {
            order.DisplayOrderDetails();
        }
    }
}

class ECommerce{
    static void Main(string[] args){
        Product p1 = new Product("Laptop", 50000);
        Product p2 = new Product("Mouse", 1500);
        Product p3 = new Product("Keyboard", 3000);

        Order o1 = new Order(101);
        o1.AddProduct(p1);
        o1.AddProduct(p2);

        Order o2 = new Order(102);
        o2.AddProduct(p2);
        o2.AddProduct(p3);

        Customer customer = new Customer("Anubhav");

        customer.PlaceOrder(o1);
        customer.PlaceOrder(o2);

        customer.ViewOrders();
    }
}
