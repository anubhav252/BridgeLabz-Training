using System;
using System.Collections.Generic;

class Patient{
    public string Name;

    public Patient(string name){
        Name = name;
    }
}

class Doctor{
    public string Name;
    private List<Patient> patients;

    public Doctor(string name)
    {
        Name = name;
        patients = new List<Patient>();
    }

    public void Consult(Patient patient)
    {
        patients.Add(patient);
        Console.WriteLine("Doctor " + Name + " is consulting patient " + patient.Name);
    }

    public void DisplayPatients()
    {
        Console.WriteLine("\nDoctor " + Name + " has consulted:");
        foreach (Patient p in patients)
        {
            Console.WriteLine("Patient: " + p.Name);
        }
    }
}

class Hospital{
    public string HospitalName;
    public List<Doctor> Doctors;
    public List<Patient> Patients;

    public Hospital(string hospitalName)
    {
        HospitalName = hospitalName;
        Doctors = new List<Doctor>();
        Patients = new List<Patient>();
    }

    public void AddDoctor(Doctor doctor)
    {
        Doctors.Add(doctor);
    }

    public void AddPatient(Patient patient)
    {
        Patients.Add(patient);
    }
}

class HospitalAndDoctors{
    static void Main(string[] args){
        Hospital hospital = new Hospital("City Care Hospital");

        Doctor d1 = new Doctor("Dr. Anubhav");
        Doctor d2 = new Doctor("Dr. Rohit");

        Patient p1 = new Patient("Amit");
        Patient p2 = new Patient("Neha");

        hospital.AddDoctor(d1);
        hospital.AddDoctor(d2);

        hospital.AddPatient(p1);
        hospital.AddPatient(p2);

        d1.Consult(p1);
        d1.Consult(p2);
        d2.Consult(p1);

        d1.DisplayPatients();
        d2.DisplayPatients();
    }
}
