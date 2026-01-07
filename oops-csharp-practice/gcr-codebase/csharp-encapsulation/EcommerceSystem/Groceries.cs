using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Platform
{
    internal class Groceries:Product
    {
        private double productDiscount;

        public override double CalculateDiscount()
        {
            return ProductPrice * 0.05;
        }
    }
}
