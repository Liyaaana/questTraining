using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPatient
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MedicalCondition { get; set; }
    }

    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string DoctorName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentType { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var patients = new List<Patient>()
            {
                new Patient { Id = 1, Name = "John Doe", Age = 35, Gender = "M", MedicalCondition = "Heart Disease" },
                new Patient { Id = 2, Name = "Jane Smith", Age = 28, Gender = "F", MedicalCondition = "Diabetes" },
                new Patient { Id = 3, Name = "Peter Parker", Age = 65, MedicalCondition = "Arthritis" },
                new Patient { Id = 4, Name = "Mary Jones", Age = 72, MedicalCondition = "Arthritis" }
            };
            var appointments = new List<Appointment>()
            {
                new Appointment { Id = 1, PatientId = 1, DoctorName = "Dr. Smith", AppointmentDate = DateTime.Now.AddDays(2), AppointmentType = "Consultation" },
                new Appointment { Id = 2, PatientId = 2, DoctorName = "Dr. Lee", AppointmentDate = DateTime.Now.AddDays(-5), AppointmentType = "Follow-up" },
                new Appointment { Id = 3, PatientId = 3, DoctorName = "Dr. Johnson", AppointmentDate = DateTime.Now.AddDays(5), AppointmentType = "Surgery" },
                new Appointment { Id = 4, PatientId = 1, DoctorName = "Dr. Brown", AppointmentDate = DateTime.Now.AddDays(-10), AppointmentType = "Check-up" },
                new Appointment { Id = 5, PatientId = 3, DoctorName = "Dr. Jones", AppointmentDate = DateTime.Now.AddDays(-20), AppointmentType = "Consultation" }
            };
            // 1. Patients with upcoming appointments within 7 days
            var upcomingAppointments = from patient in patients
                                       join appointment in appointments on patient.Id equals appointment.PatientId
                                       where appointment.AppointmentDate >= DateTime.Now && appointment.AppointmentDate <= DateTime.Now.AddDays(7)
                                       select new { Name = patient.Name, Age = patient.Age, MedicalCondition = patient.MedicalCondition };

            Console.WriteLine("Patients with upcoming appointments (next 7 days):");
            foreach (var patient in upcomingAppointments)
            {
                Console.WriteLine(< span class="math-inline">" \- \{patient\.Name\}, \{patient\.Age\} \(\{patient\.MedicalCondition\}\)"\);
            \}


        }
    }
}
