using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_Lab___Class_Design
{
    class Service
    {
        int serviceId;
        int carId;
        int customerId;
        string serviceDescription;
        decimal cost;
        int timeToComplete;

        public Service(int serviceId, int carId, int customerId, string serviceDescription, decimal cost, int timeToComplete)
        {
            this.serviceId = serviceId;
            this.carId = carId;
            this.customerId = customerId;
            this.serviceDescription = serviceDescription;
            this.cost = cost;
            this.timeToComplete = timeToComplete;
        }

        public int ServiceId { get => serviceId; set => serviceId = value; }
        public int CarId { get => carId; set => carId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public string ServiceDescription { get => serviceDescription; set => serviceDescription = value; }
        public decimal Cost { get => cost; set => cost = value; }
        public int TimeToComplete { get => timeToComplete; set => timeToComplete = value; }
    }
}
