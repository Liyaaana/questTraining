using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentSystem
{
    public class AppointmentManager
    {
        private readonly List<Appointment> _appointments = new List<Appointment>();
        private readonly TimeSpan _workStartTime = new TimeSpan(9, 0, 0); // 9:00 AM
        private readonly TimeSpan _workEndTime = new TimeSpan(17, 0, 0);  // 5:00 PM

        public bool BookAppointment(string patientName, DateTime startTime, DateTime endTime)
        {
            // Check if the appointment is within working hours
            if (!IsWithinWorkingHours(startTime, endTime))
            {
                Console.WriteLine("Appointment is outside of working hours.");
                return false;
            }

            // Check if the time slot is available
            if (!IsTimeSlotAvailable(startTime, endTime))
            {
                Console.WriteLine("The requested time slot is not available.");
                return false;
            }

            // Book the appointment
            Appointment appointment = new Appointment
            {
                PatientName = patientName,
                StartTime = startTime,
                EndTime = endTime
            };
            _appointments.Add(appointment);
            Console.WriteLine($"Appointment successfully booked for {patientName} from {startTime} to {endTime}.");
            return true;
        }

        public List<Appointment> GetAppointments()
        {
            return _appointments;
        }

        public bool IsTimeSlotAvailable(DateTime startTime, DateTime endTime)
        {
            foreach (var appointment in _appointments)
            {
                // Check for any overlap
                if ((startTime < appointment.EndTime) && (endTime > appointment.StartTime))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsWithinWorkingHours(DateTime startTime, DateTime endTime)
        {
            TimeSpan startOfAppointment = startTime.TimeOfDay;
            TimeSpan endOfAppointment = endTime.TimeOfDay;

            return startOfAppointment >= _workStartTime && endOfAppointment <= _workEndTime;
        }
    }
}