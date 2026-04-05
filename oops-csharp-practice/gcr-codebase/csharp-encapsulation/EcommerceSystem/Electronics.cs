using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Platform
{
    
    internal class Electronics:Product,ITaxable
    {
        public override double CalculateDiscount()
        {
            return ProductPrice * 0.10;
        }

        public double CalculateTax()
        {
            return ProductPrice * 0.18;
        }

        public string GetTaxDetails()
        {
            return "18% GST on Electronics";
        }
    }
}
