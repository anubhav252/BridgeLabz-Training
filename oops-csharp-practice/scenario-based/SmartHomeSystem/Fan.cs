using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Appliance
{
    internal class Fan:Appliance,IControllable
    {
        private bool on = false;
        private bool off = false;
        public void TurnOn()
        {
            on = true;
            off = false;

        }
        public void TurnOff()
        {
            on = false;
            off = true;
        }
        public void DisplayStatus()
        {
            if (on)
            {
                Console.WriteLine(ApplianceName + " is Currently on and consuming power " + AppliancePowerConsumption+" watt");
            }
            else
            {
                Console.WriteLine(ApplianceName + " is Currently off and not consuming any power");
            }
        }
    }
}
