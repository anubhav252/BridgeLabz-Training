using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Appliance
{
    internal interface IControllable
    {
        void TurnOn();
        void TurnOff();

        void DisplayStatus();

    }
}
