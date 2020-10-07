using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    interface ISmartDevice
    {
        void TurnOn();
        void TurnOff();
        bool GetStatus();
        bool IsCritical();
    }
}
