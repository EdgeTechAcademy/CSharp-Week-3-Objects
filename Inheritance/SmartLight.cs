using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class SmartLight : ISmartDevice
    {
        bool LightOn { get; set; }
        bool isCritical { get; set; }
        public bool GetStatus()
        {
            return LightOn;
        }

        public bool IsCritical()
        {
            return false;
        }

        public void TurnOff()
        {
            LightOn = false;
        }

        public void TurnOn()
        {
            LightOn = true;
        }
    }
}
