using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/*
You are building a healthcare management system. You have two entities: Patient and Appointment.
Patient: Stores information about patients.
Id: Unique identifier of the patient.
Name: Name of the patient.
Age: Age of the patient.
Gender: Gender of the patient.
MedicalCondition: Primary medical condition of the patient.
 
Appointment: Stores information about the appointments made by patients.
 
Id: Unique identifier of the appointment.
PatientId: The ID of the patient who has the appointment.
DoctorName: The name of the doctor for the appointment.
AppointmentDate: Date and time of the appointment.
AppointmentType: Type of appointment (e.g., "Consultation", "Surgery", "Follow-up").
 
Task:
Using LINQ, write a query to find the following information:
 
List all the patients (name, age, medical condition) who have an upcoming appointment within the next 7 days.
 
Group the patients by their MedicalCondition and return the total number of patients in each condition category who have upcoming appointments.
 
Find the patient(s) with the most appointments in the last 30 days. If there are multiple patients with the same number of appointments, return all of them.
 
For patients over the age of 60, list the patient names along with their most recent appointment (doctor's name, date, and type of appointment).
*/

namespace HealthCare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new HealthCareManager().ListUpcomingAppontmentsInNextSevenDays();
        }
    }
}
