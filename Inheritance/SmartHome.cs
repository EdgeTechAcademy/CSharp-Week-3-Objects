using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class SmartHome
    {
        static void Main(string[] args)
        {
            List<ISmartDevice> smartDevices = new List<ISmartDevice>();
            SmartFan bedroom1 = new SmartFan();
            SmartFan bedroom2 = new SmartFan();
            SmartFan bedroom3 = new SmartFan();
            SmartFan bedroom4 = new SmartFan();
            smartDevices.Add(bedroom1);
            smartDevices.Add(bedroom2);
            smartDevices.Add(bedroom3);
            smartDevices.Add(bedroom4);
            SmartLight brm1 = new SmartLight();
            SmartLight brm2 = new SmartLight();
            SmartLight brm3 = new SmartLight();
            SmartLight brm4 = new SmartLight();
            smartDevices.Add(brm1);
            smartDevices.Add(brm2);
            smartDevices.Add(brm3);
            smartDevices.Add(brm4);

            SmartFridge kitchen = new SmartFridge();
            smartDevices.Add(kitchen);

            OnVacation(smartDevices);
        }
        static void OnVacation(List<ISmartDevice> devices)
        {
            foreach (var device in devices)
            {
                if (!device.IsCritical())
                    device.TurnOff();
            }
        }
    }
}
