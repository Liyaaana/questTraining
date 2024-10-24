CREATE TABLE Patient
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    Age INT,
    Gender VARCHAR(10),
    MedicalCondition VARCHAR(100)
);

CREATE TABLE Doctor
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    Specialization VARCHAR(100),
    PatientId INT NULL, 
    FOREIGN KEY (PatientId) REFERENCES Patient(Id)
);