using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_Lab___Class_Design
{
    class Treatment
    {
        int treatmentId;
        int patientId;
        string prescription;
        int duration;         // in days
        DateTime dateIssued;

        public Treatment(int treatmentId, int patientId, string prescription, int duration, DateTime dateIssued)
        {
            this.treatmentId = treatmentId;
            this.patientId = patientId;
            this.prescription = prescription;
            this.duration = duration;
            this.dateIssued = dateIssued;
        }

        public int TreatmentId { get => treatmentId; set => treatmentId = value; }
        public int PatientId { get => patientId; set => patientId = value; }
        public string Prescription { get => prescription; set => prescription = value; }
        public int Duration { get => duration; set => duration = value; }
        public DateTime DateIssued { get => dateIssued; set => dateIssued = value; }
    }
}
