using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_Lab___Class_Design
{
    class Appointment
    {
        int appointmentId;
        int patientId;
        DateTime appointmentDateTime;
        string drName;

        public Appointment(int appointmentId, int patientId, DateTime appointmentDateTime, string drName)
        {
            this.appointmentId = appointmentId;
            this.patientId = patientId;
            this.appointmentDateTime = appointmentDateTime;
            this.drName = drName;
        }

        public int AppointmentId { get => appointmentId; set => appointmentId = value; }
        public int PatientId { get => patientId; set => patientId = value; }
        public DateTime AppointmentDateTime { get => appointmentDateTime; set => appointmentDateTime = value; }
        public string DrName { get => drName; set => drName = value; }
    }
}
