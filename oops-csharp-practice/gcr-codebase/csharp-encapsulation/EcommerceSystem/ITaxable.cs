using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Platform
{
    internal interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    }
}
