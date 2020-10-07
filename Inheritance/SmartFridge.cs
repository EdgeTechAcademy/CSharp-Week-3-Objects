using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class SmartFridge : ISmartDevice
    {
        int Temp { get; set; }
        bool On { get; set; }
        bool isCritical { get; set; }
        public bool GetStatus()
        {
            return On;
        }

        public bool IsCritical()
        {
            return true;
        }

        public void TurnOff()
        {
            On = false;
        }

        public void TurnOn()
        {
            On = true;
            Temp = 0;
        }
    }
}