using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Platform
{
    internal class Clothing:Product,ITaxable
    {
        public override double CalculateDiscount()
        {
            return ProductPrice * 0.20;
        }

        public double CalculateTax()
        {
            return ProductPrice * 0.05;
        }

        public string GetTaxDetails()
        {
            return "5% GST on Clothing";
        }
    }
}
