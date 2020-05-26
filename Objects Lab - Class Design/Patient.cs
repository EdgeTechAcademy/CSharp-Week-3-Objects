using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_Lab___Class_Design
{
    class Patient
    {
int patientId;
        string name;     // (first and last if you want)
        string state;
        string zip;
        DateTime dob;

        public Patient(string name, string state, string zip, DateTime dob)
        {
            this.name = name;
            this.state = state;
            this.zip = zip;
            this.dob = dob;
        }

        public string Name { get => name; set => name = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public DateTime Dob { get => dob; set => dob = value; }
    }
}
