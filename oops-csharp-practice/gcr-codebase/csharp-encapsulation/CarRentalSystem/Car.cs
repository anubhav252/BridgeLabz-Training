using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    class Car : Vehicle, IInsurable
    {
        private string insurancePolicyNo;   

        public Car(string number, double rate, string policyNo)
            : base(number, "Car", rate)
        {
            insurancePolicyNo = policyNo;
        }

        public override double CalculateRentalCost(int days)
        {
            return rentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 500; 
        }

        public string GetInsuranceDetails()
        {
            return "Car Insurance Applied";
        }
    }
}
