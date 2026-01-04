using System;

class Patient{
    public static string HospitalName = "City Care Hospital";
    private static int totalPatients = 0;

    public readonly int PatientID;
    private string Name;
    private int Age;
    private string Ailment;

    public Patient(int PatientID, string Name, int Age, string Ailment){
        this.PatientID = PatientID;
        this.Name = Name;
        this.Age = Age;
        this.Ailment = Ailment;
        totalPatients++;
    }

    public static void GetTotalPatients(){
        Console.WriteLine("Total Patients Admitted: " + totalPatients);
    }

    public void DisplayPatientDetails(){
        Console.WriteLine("Hospital Name : " + HospitalName);
        Console.WriteLine("Patient ID    : " + PatientID);
        Console.WriteLine("Name          : " + Name);
        Console.WriteLine("Age           : " + Age);
        Console.WriteLine("Ailment       : " + Ailment);
        Console.WriteLine("------------------------------");
    }
}

class HospitalManagementSystem{
    static void Main(string[] args){
        Patient p1 = new Patient(1, "Anubhav", 22, "Fever");
        Patient p2 = new Patient(2, "Rohit", 30, "Injury");

        if (p1 is Patient){
            p1.DisplayPatientDetails();
        }

        if (p2 is Patient){
            p2.DisplayPatientDetails();
        }

        Patient.GetTotalPatients();
    }
}
