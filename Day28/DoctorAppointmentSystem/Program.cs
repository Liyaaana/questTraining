using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppointmentManager appointmentManager = new AppointmentManager();

            // Example of booking appointments
            DateTime startTime1 = new DateTime(2024, 11, 12, 10, 0, 0); // 10:00 AM
            DateTime endTime1 = new DateTime(2024, 11, 12, 11, 0, 0);   // 11:00 AM
            appointmentManager.BookAppointment("Alice", startTime1, endTime1);

            DateTime startTime2 = new DateTime(2024, 11, 12, 10, 30, 0); // Overlapping appointment
            DateTime endTime2 = new DateTime(2024, 11, 12, 11, 30, 0);
            appointmentManager.BookAppointment("Bob", startTime2, endTime2);

            DateTime startTime3 = new DateTime(2024, 11, 12, 12, 0, 0); // Non-overlapping
            DateTime endTime3 = new DateTime(2024, 11, 12, 13, 0, 0);
            appointmentManager.BookAppointment("Charlie", startTime3, endTime3);

            // Display all appointments
            var appointments = appointmentManager.GetAppointments();
            Console.WriteLine("\nScheduled Appointments:");
            foreach (var appointment in appointments)
            {
                Console.WriteLine($"{appointment.PatientName}: {appointment.StartTime} - {appointment.EndTime}");
            }
        }
    }
}

    