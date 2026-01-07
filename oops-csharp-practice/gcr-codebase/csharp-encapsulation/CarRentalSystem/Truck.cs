using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    class Truck : Vehicle, IInsurable
    {
        private string insurancePolicyNo;

        public Truck(string number, double rate, string policyNo)
            : base(number, "Truck", rate)
        {
            insurancePolicyNo = policyNo;
        }

        public override double CalculateRentalCost(int days)
        {
            return (rentalRate * days) + 1000; 
        }

        public double CalculateInsurance()
        {
            return 1000;
        }

        public string GetInsuranceDetails()
        {
            return "Truck Insurance Applied";
        }
    }
}
