﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientRecord
{
    internal class Program
    {

        class Patient
        {
            public string name { get; set; }
            public int age { get; set; }
            public string diagnosis { get; set; }
            public bool admitted { get; set; }
        }
        static List<Patient> patientList = new List<Patient>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Options:");
                Console.WriteLine("1. Add New Patient");
                Console.WriteLine("2. Search Patient");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1/2/3): ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddNewPatient();
                            break;
                        case 2:
                            SearchPatient();
                            break;
                        case 3:
                            Console.WriteLine("Exit");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
                }
            }
        }

        static void AddNewPatient()
        {
            Console.Write("Enter patient name: ");
            string name = Console.ReadLine();

            Console.Write("Enter patient age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.Write("Enter patient diagnosis: ");
                string diagnosis = Console.ReadLine();
                patientList.Add(new Patient { name = name, age = age, diagnosis = diagnosis, admitted = true });
                Console.WriteLine("Patient added successfully");
            }
            else
            {
                Console.WriteLine("Invalid age. Please enter a valid integer.");
            }
        }

        static void SearchPatient()
        {
            Console.Write("Enter patient name to search: ");
            string searchName = Console.ReadLine()?.ToLower();
            Patient foundPatient = null;
            foreach (var patient in patientList)
            {
                if (patient.name?.ToLower() == searchName)
                {
                    foundPatient = patient;
                    break;
                }
            }

            if (foundPatient != null)
            {
                Console.WriteLine($"Patient found:");
                Console.WriteLine($"name: {foundPatient.name}");
                Console.WriteLine($"age: {foundPatient.age}");
                Console.WriteLine($"diagnosis: {foundPatient.diagnosis}");
                Console.WriteLine($"Admission Status: {(foundPatient.admitted ? "Admitted" : "Discharged")}");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }
    }
}
