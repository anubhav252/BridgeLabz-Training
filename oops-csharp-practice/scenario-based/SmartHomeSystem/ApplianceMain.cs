using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Appliance
{
    internal class ApplianceMain
    {
        private static Appliance[] appliances=new Appliance[3];
        static void Main(string[] args) {
            appliances[0] = new Light();

            appliances[0].ApplianceName = "Light";
            appliances[0].AppliancePowerConsumption = 80;
            appliances[1] = new Fan();
            appliances[1].ApplianceName = "Fan";
            appliances[1].AppliancePowerConsumption = 250;
            appliances[2] = new Ac();
            appliances[2].ApplianceName = "Ac";
            appliances[2].AppliancePowerConsumption = 880;

            for (int i = 0; i < appliances.Length; i++)
            {
                Console.WriteLine(appliances[i]);
                Console.WriteLine("-------------------");
            }


            for (int i = 0; i < appliances.Length; i++)
            {
                if (appliances[i] is Light light)
                {
                    light.TurnOn();
                }
                if (appliances[i] is IControllable controllable)
                {

                    controllable.DisplayStatus();
                }

            }
        }
    }
}
