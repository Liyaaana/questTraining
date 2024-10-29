using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Using Db connection in C# give simple code including abstract ,interface , Enum to the below question                         
Patient and Doctor Management System Using MSSQL
Task:
Create a C# console application that interacts with an MSSQL database to manage records of patients and doctors. Focus on basic CRUD operations for two separate tables: Patient and Doctor.
1. Database Schema
Patient Table
Fields:
Id (INT, Primary Key) – Unique identifier of the patient.
Name (NVARCHAR(100)) – Name of the patient.
Age (INT) – Age of the patient.
Gender (NVARCHAR(10)) – Gender of the patient.
MedicalCondition (NVARCHAR(200)) – Medical condition of the patient.
Doctor Table
Fields:
Id (INT, Primary Key) – Unique identifier of the doctor.
Name (NVARCHAR(100)) – Name of the doctor.
Specialization (NVARCHAR(100)) – Specialization of the doctor (e.g., Cardiologist, Neurologist).
PatientId (INT, Optional) – A nullable field to assign a patient to the doctor if needed (foreign key to Patient.Id).
2. Application Requirements
Perform CRUD Operations for Patients and Doctors
Implement the following operations using ADO.NET, keeping the operations simple for each table:
Create:
Add a new patient to the Patient table.
Add a new doctor to the Doctor table.
Read:
Retrieve and display a list of all patients with their details (name, age, medical condition).
Retrieve and display a list of all doctors with their specializations.
Update:
Update a patient’s details (e.g., medical condition).
Update a doctor’s specialization.
Delete:
Delete a patient record from the Patient table.
Delete a doctor record from the Doctor table.
*/

namespace PatientDoctorManagementSystem
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public abstract class Datails
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Patient : Datails
    {
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string MedicalCondition { get; set; }
    }

    public class Doctor : Datails
    {
        public string Specialization { get; set; }
        public int? PatientId { get; set; }
    }

    public class DatabaseConnection
    {
        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\liyan\\OneDrive\\Documents\\QuestDB.mdf;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

    public class PatientDoctorRepository
    {
        private readonly DatabaseConnection _dbConnection = new DatabaseConnection();

        public void AddPatient(Patient patient)
        {
            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Patient (Name, Age, Gender, MedicalCondition) VALUES (@Name, @Age, @Gender, @MedicalCondition)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Name", patient.Name);
                    command.Parameters.AddWithValue("@Age", patient.Age);
                    command.Parameters.AddWithValue("@Gender", patient.Gender.ToString());
                    command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddDoctor(Doctor doctor)
        {
            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Doctor (Name, Specialization, PatientId) VALUES (@Name, @Specialization, @PatientId)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Name", doctor.Name);
                    command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                    command.Parameters.AddWithValue("@PatientId", doctor.PatientId.HasValue ? (object)doctor.PatientId.Value : DBNull.Value);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id, Name, Age, Gender, MedicalCondition FROM Patient";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patients.Add(new Patient
                            {
                                Id = (int)reader["Id"],
                                Name = reader["Name"].ToString(),
                                Age = (int)reader["Age"],
                                Gender = (Gender)Enum.Parse(typeof(Gender), reader["Gender"].ToString()),
                                MedicalCondition = reader["MedicalCondition"].ToString()
                            });
                        }
                    }
                }
            }
            return patients;
        }

        public List<Doctor> GetDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id, Name, Specialization, PatientId FROM Doctor";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doctors.Add(new Doctor
                            {
                                Id = (int)reader["Id"],
                                Name = reader["Name"].ToString(),
                                Specialization = reader["Specialization"].ToString(),
                                PatientId = reader["PatientId"] != DBNull.Value ? (int)reader["PatientId"] : (int?)null
                            });
                        }
                    }
                }
            }
            return doctors;
        }

        public void UpdatePatient(Patient patient)
        {
            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Patient SET Name = @Name, Age = @Age, Gender = @Gender, MedicalCondition = @MedicalCondition WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Id", patient.Id);
                    command.Parameters.AddWithValue("@Name", patient.Name);
                    command.Parameters.AddWithValue("@Age", patient.Age);
                    command.Parameters.AddWithValue("@Gender", patient.Gender.ToString());
                    command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateDoctor(Doctor doctor)
        {
            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Doctor SET Name = @Name, Specialization = @Specialization, PatientId = @PatientId WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Id", doctor.Id);
                    command.Parameters.AddWithValue("@Name", doctor.Name);
                    command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                    command.Parameters.AddWithValue("@PatientId", doctor.PatientId.HasValue ? (object)doctor.PatientId.Value : DBNull.Value);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeletePatient(int id)
        {
            string patientName = GetPatientNameById(id);

            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Patient WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine($"Patient {patientName} has been deleted.");
        }

        public void DeleteDoctor(int id)
        {
            string doctorName = GetDoctorNameById(id);

            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Doctor WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine($"Doctor {doctorName} has been deleted.");
        }

        private string GetPatientNameById(int id)
        {
            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT Name FROM Patient WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    return (string)command.ExecuteScalar();
                }
            }
        }

        private string GetDoctorNameById(int id)
        {
            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT Name FROM Doctor WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    return (string)command.ExecuteScalar();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PatientDoctorRepository repository = new PatientDoctorRepository();

            repository.AddPatient(new Patient
            {
                Name = "Sam",
                Age = 30,
                Gender = Gender.Male,
                MedicalCondition = "Cardiac Arrest"
            });

            repository.AddDoctor(new Doctor
            {
                Name = "Dr.John",
                Specialization = "Cardiologist",
                PatientId = null
            });

            var patients = repository.GetPatients();
            foreach (var patient in patients)
            {
                Console.WriteLine($"Patient: {patient.Name}, Age: {patient.Age}, Condition: {patient.MedicalCondition}");
            }

            var doctors = repository.GetDoctors();
            foreach (var doctor in doctors)
            {
                string patientInfo = doctor.PatientId.HasValue ? doctor.PatientId.ToString() : "Not Assigned";
                Console.WriteLine($"Doctor: {doctor.Name}, Specialization: {doctor.Specialization}, PatientId: {patientInfo}");
            }

            var patientToUpdate = patients.First();
            patientToUpdate.MedicalCondition = "Recovered";
            repository.UpdatePatient(patientToUpdate);

            var doctorToUpdate = doctors.First();
            doctorToUpdate.Specialization = "Neurologist"; 
            repository.UpdateDoctor(doctorToUpdate);


            repository.DeletePatient(patients[0].Id);
            repository.DeleteDoctor(doctors[0].Id);

        }
    }
}