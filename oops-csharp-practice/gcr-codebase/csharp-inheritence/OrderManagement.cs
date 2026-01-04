using System;

class Order{
    protected int OrderId;
    protected DateTime OrderDate;

    public Order(int orderId, DateTime orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Order ID   : " + OrderId);
        Console.WriteLine("Order Date : " + OrderDate.ToShortDateString());
        Console.WriteLine("Status     : " + GetOrderStatus());
    }
}

class ShippedOrder : Order
{
    protected string TrackingNumber;

    public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    public override string GetOrderStatus()
    {
        return "Order Shipped";
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Tracking No: " + TrackingNumber);
    }
}

class DeliveredOrder : ShippedOrder{
    private DateTime DeliveryDate;

    public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    public override string GetOrderStatus()
    {
        return "Order Delivered";
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Delivery Date: " + DeliveryDate.ToShortDateString());
    }
}

class OrderManagement{
    static void Main(string[] args){
        Order o1 = new Order(101, DateTime.Now);
        Order o2 = new ShippedOrder(102, DateTime.Now.AddDays(-2), "TRK12345");
        Order o3 = new DeliveredOrder(103, DateTime.Now.AddDays(-5), "TRK67890", DateTime.Now);

        Console.WriteLine("----- Order 1 -----");
        o1.DisplayDetails();

        Console.WriteLine("\n----- Order 2 -----");
        o2.DisplayDetails();

        Console.WriteLine("\n----- Order 3 -----");
        o3.DisplayDetails();
    }
}
