using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Appliance
{
    internal abstract class Appliance
    {
        private string applianceName;
        private double appliancePowerConsumption;

        public string ApplianceName{
            get { return applianceName; }
            set { applianceName = value; }
        }

        public double AppliancePowerConsumption
        {
            get { return appliancePowerConsumption; }
            set
            {
                if (value > 0)
                {
                    appliancePowerConsumption = value;
                }
            }
        }
       
        public override string ToString()
        {
            return ("Appliance Name : " + ApplianceName + "\nPower Consumption : " + AppliancePowerConsumption + "watt");
        }
    }
}
