using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  OnlineFoodOrderingSystem
{
    interface IDiscountable
    {
        double ApplyDiscount();
        string GetDiscountDetails();
    }

    abstract class FoodItem
    {
        private string itemName;
        private double price;
        private int quantity;

        public string ItemName
        {
            get { return itemName; }
            protected set { itemName = value; }
        }

        public double Price
        {
            get { return price; }
            protected set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }

        public int Quantity
        {
            get { return quantity; }
            protected set
            {
                if (value > 0)
                {
                    quantity = value;
                }
            }
        }

        protected FoodItem(string name, double price, int quantity)
        {
            ItemName = name;
            Price = price;
            Quantity = quantity;
        }

        public abstract double CalculateTotalPrice();

        public void GetItemDetails()
        {
            Console.WriteLine("Item Name : " + ItemName);
            Console.WriteLine("Price     : " + Price);
            Console.WriteLine("Quantity  : " + Quantity);
        }
    }

    class VegItem : FoodItem, IDiscountable
    {
        private const double PackagingCharge = 20;

        public VegItem(string name, double price, int quantity)
            : base(name, price, quantity) { }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + PackagingCharge;
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.10;
        }

        public string GetDiscountDetails()
        {
            return "10% discount on Veg Items";
        }
    }

    class NonVegItem : FoodItem, IDiscountable
    {
        private const double PackagingCharge = 40;
        private const double ExtraTax = 0.05;

        public NonVegItem(string name, double price, int quantity)
            : base(name, price, quantity) { }

        public override double CalculateTotalPrice()
        {
            double baseAmount = Price * Quantity;
            return baseAmount + PackagingCharge + (baseAmount * ExtraTax);
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.05;
        }

        public string GetDiscountDetails()
        {
            return "5% discount on Non-Veg Items";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FoodItem[] orderItems = {
                new VegItem("Paneer Burger", 120, 2),
                new NonVegItem("Chicken Pizza", 350, 1)
            };

            foreach (FoodItem item in orderItems)
            {
                item.GetItemDetails();

                double totalPrice = item.CalculateTotalPrice();
                double discount = 0;

                if (item is IDiscountable discountable)
                {
                    discount = discountable.ApplyDiscount();
                    Console.WriteLine(discountable.GetDiscountDetails());
                }

                Console.WriteLine("Total Price : " + totalPrice);
                Console.WriteLine("Discount    : " + discount);
                Console.WriteLine("Final Price : " + (totalPrice - discount));
                Console.WriteLine("---------------------------");
            }
        }
    }
}
