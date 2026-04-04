using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Platform
{
    internal abstract class Product
    {
        private int productId;
        private string productName;
        private double productPrice;
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public double ProductPrice
        {
            get { return productPrice; }
            set { if (value > 0) { 
                    productPrice = value;
                } 
            }
        }
        public abstract double CalculateDiscount();
        public override string ToString()
        {
            return ("Product Id : " + productId + "\nProduct Name : " + productName + "\nProduct Price : " + productPrice);
        }
    }
}
