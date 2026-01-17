using System;
namespace FlashDealz
{
    class Product
    {
        private string productName;
        private double productPrice;

        private double discountPercentage;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        public double DiscountPercentage
        {
            get { return discountPercentage; }
            set { 
                if(value>0 && value < 100)
                {
                    discountPercentage = value;
                }
            }
        }
        public Product(string name, double price, double discount)
        {
            productName = name;
            productPrice = price;
            DiscountPercentage = discount;
        }
        public override string ToString()
        {
            return ($"Product Name: {ProductName}, Price: {ProductPrice}, Discount: {DiscountPercentage}%");
        }
    }
}