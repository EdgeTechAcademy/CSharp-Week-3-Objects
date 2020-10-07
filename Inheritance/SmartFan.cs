using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Inheritance
{
    class SmartFan : ISmartDevice
    {
        int Speed { get; set; }
        bool FanOn { get; set; }
        bool IsCritical { get; set; }
 

        public bool IsCritical()
        {
            return false;
        }

        public void TurnOff()
        {
            FanOn = false;
            Speed = 0;
        }

        public void TurnOn()
        {
            FanOn = true;
            Speed = 1;
        }

        public bool GetStatus()
        {
            return FanOn;
        }
    }
}
