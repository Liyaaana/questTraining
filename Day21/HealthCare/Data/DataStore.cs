using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare
{
    internal class DataStore
    {
        public List<Patient> Patients { get; set; } = new List<Patient>();
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        public DataStore()
        {
            // Sample data
            Patients.Add(new Patient { Id = 1, Name = "John Doe", Age = 65, Gender = "Male", MedicalCondition = "Diabetes" });
            Patients.Add(new Patient { Id = 2, Name = "Jane Smith", Age = 45, Gender = "Female", MedicalCondition = "Hypertension" });
            Patients.Add(new Patient { Id = 3, Name = "Mike Brown", Age = 70, Gender = "Male", MedicalCondition = "Heart Disease" });

            Appointments.Add(new Appointment { Id = 1, PatientId = 1, DoctorName = "Dr. Adams", AppointmentDate = DateTime.Now.AddDays(3), AppointmentType = "Consultation" });
            Appointments.Add(new Appointment { Id = 2, PatientId = 2, DoctorName = "Dr. Baker", AppointmentDate = DateTime.Now.AddDays(5), AppointmentType = "Follow-up" });
            Appointments.Add(new Appointment { Id = 3, PatientId = 3, DoctorName = "Dr. Carter", AppointmentDate = DateTime.Now.AddDays(-10), AppointmentType = "Surgery" });
            Appointments.Add(new Appointment { Id = 4, PatientId = 1, DoctorName = "Dr. Adams", AppointmentDate = DateTime.Now.AddDays(-20), AppointmentType = "Follow-up" });
            Appointments.Add(new Appointment { Id = 5, PatientId = 1, DoctorName = "Dr. Adams", AppointmentDate = DateTime.Now.AddDays(-5), AppointmentType = "Consultation" });

            /*
            // Initialize some sample data for Patients and Appointments
            Patients = new List<Patient>
            {
                new Patient(1, "John Doe", 35, "Diabetes"),
                new Patient(2, "Jane Smith", 29, "Hypertension"),
                new Patient(3, "Mike Johnson", 45, "Asthma")
            };

            Appointments = new List<Appointment>
            {
                new Appointment(1, 1, DateTime.Now.AddDays(3)),
                new Appointment(2, 2, DateTime.Now.AddDays(5)),
                new Appointment(3, 3, DateTime.Now.AddDays(-10)),
                new Appointment(4, 1, DateTime.Now.AddDays(-15)),
                new Appointment(5, 1, DateTime.Now.AddDays(-5)),
                new Appointment(6, 2, DateTime.Now.AddDays(-20))
            };
            */
        }
    }
}