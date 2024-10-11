using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questn2
{
    /*
    
    class Program
    {
        static List<int> patientIds = new List<int>();
        static List<string> patientNames = new List<string>();
        static List<int> patientAges = new List<int>();
        static List<List<string>> patientSymptoms = new List<List<string>>();

        static int nextId = 1;

        // Function to add a new patient
        static void AddPatient(string name, int age, List<string> symptoms)
        {
            patientIds.Add(nextId);
            patientNames.Add(name);
            patientAges.Add(age);
            patientSymptoms.Add(symptoms);
            Console.WriteLine($"Patient added with ID: {nextId}");
            nextId++;
        }

        // Function to get patient details by ID
        static void GetPatient(int id)
        {
            int index = patientIds.IndexOf(id);
            if (index != -1)
            {
                Console.WriteLine($"\nPatient Found - ID: {patientIds[index]}, Name: {patientNames[index]}, Age: {patientAges[index]}, Symptoms: {string.Join(", ", patientSymptoms[index])}");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }

        // Function to get patients by symptom
        static void GetPatientsBySymptom(string symptom)
        {
            List<int> matchingPatients = new List<int>();
            for (int i = 0; i < patientSymptoms.Count; i++)
            {
                if (patientSymptoms[i].Contains(symptom))
                {
                    matchingPatients.Add(patientIds[i]);
                }
            }

            if (matchingPatients.Count > 0)
            {
                Console.WriteLine("\nPatients with " + symptom + ": " + string.Join(", ", matchingPatients));
            }
            else
            {
                Console.WriteLine("\nNo patients found with the symptom: " + symptom);
            }
        }

        static void Main(string[] args)
        {
            // Adding patients
            AddPatient("John Doe", 30, new List<string> { "Fever", "Cough" });
            AddPatient("Jane Smith", 25, new List<string> { "Headache", "Nausea" });

            // Retrieve patient by ID
            GetPatient(1);

            // Retrieve patients by symptom
            GetPatientsBySymptom("Fever");
        }
    }
    */


    internal class Program
    {
        //dictionary to store the data
        static Dictionary<int, Dictionary<string, string>> patients = new Dictionary<int, Dictionary<string, string>>();

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("WELCOME TO PATIENT DIAGNOSIS MANAGEMENT SYSTEM");
                Console.WriteLine("1.Add Patient");
                Console.WriteLine("2.Get Patient");
                Console.WriteLine("3.Get Patient by Symptom");
                Console.WriteLine("4.Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddPatient();
                        break;
                    case 2:
                        GetPatient();
                        break;
                    case 3:
                        GetPatientBySymptom();
                        break;
                    case 4:
                        return;


                }
            }

        }

        public static void GetPatientBySymptom()
        {
            Console.Write("Enter the symptoms: ");
            string symptoms = Console.ReadLine();
            foreach (var patient in patients)
            {
                var details = patient.Value;
                if (details["Symptoms"].Contains(symptoms))
                {
                    Console.WriteLine($"Patient ID: {patient.Key}");
                }
            }
        }

        public static void GetPatient()
        {
            Console.Write("Enter the id: ");
            int id = int.Parse(Console.ReadLine());
            if (patients.ContainsKey(id))
            {
                Console.WriteLine($"patient id {id}");
                var patient = patients[id];
                Console.WriteLine($"Name: {patient["Name"]}");
                Console.WriteLine($"Age: {patient["Age"]}");
                Console.WriteLine($"Symptoms: {patient["Symptoms"]}");

            }
            else
            {
                Console.WriteLine("id is not found");
            }
        }

        public static void AddPatient()
        {
            Console.Write("Enter the id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the age: ");
            string age = Console.ReadLine();
            Console.Write("Enter the symptoms as comma separated: ");
            string symptoms = Console.ReadLine();


            patients.Add(id, new Dictionary<string, string>
            {
                {"Name", name },
                {"Age",age },
                {"Symptoms",symptoms}


            });
            Console.WriteLine("patient added");

        }

    }
}

