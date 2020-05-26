using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_Lab___Class_Design
{
    class Vehicle
    {
        int vehicleId;
        int customerId;
        string make;
        string model;
        int mileage;

        public Vehicle(int vehicleId, int customerId, string make, string model, int mileage)
        {
            this.vehicleId = vehicleId;
            this.customerId = customerId;
            this.make = make;
            this.model = model;
            this.mileage = mileage;
        }

        public int VehicleId { get => vehicleId; set => vehicleId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Mileage { get => mileage; set => mileage = value; }
    }
}
