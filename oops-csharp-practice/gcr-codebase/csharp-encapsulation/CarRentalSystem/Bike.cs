using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    class Bike : Vehicle, IInsurable
    {
        private string insurancePolicyNo;

        public Bike(string number, double rate, string policyNo)
            : base(number, "Bike", rate)
        {
            insurancePolicyNo = policyNo;
        }

        public override double CalculateRentalCost(int days)
        {
            return rentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 200;
        }

        public string GetInsuranceDetails()
        {
            return "Bike Insurance Applied";
        }
    }
}
