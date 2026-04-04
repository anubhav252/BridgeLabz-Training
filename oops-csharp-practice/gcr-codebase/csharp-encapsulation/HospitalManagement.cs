using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    interface IMedicalRecord
    {
        void AddRecord(string diagnosis);
        void ViewRecords();
    }

    abstract class Patient
    {
        private int patientId;
        private string name;
        private int age;
        private string medicalHistory;

        public int PatientId
        {
            get { return patientId; }
            protected set { patientId = value; }
        }

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public int Age
        {
            get { return age; }
            protected set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }

        protected string MedicalHistory
        {
            get { return medicalHistory; }
            set { medicalHistory = value; }
        }

        protected Patient(int id, string name, int age)
        {
            PatientId = id;
            Name = name;
            Age = age;
        }

        public abstract double CalculateBill();

        public void GetPatientDetails()
        {
            Console.WriteLine("Patient Id : " + PatientId);
            Console.WriteLine("Name       : " + Name);
            Console.WriteLine("Age        : " + Age);
        }
    }

    class InPatient : Patient, IMedicalRecord
    {
        private int numberOfDays;
        private double dailyCharge;

        public InPatient(int id, string name, int age, int days, double chargePerDay)
            : base(id, name, age)
        {
            numberOfDays = days;
            dailyCharge = chargePerDay;
        }

        public override double CalculateBill()
        {
            return numberOfDays * dailyCharge;
        }

        public void AddRecord(string diagnosis)
        {
            MedicalHistory = diagnosis;
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Record : " + MedicalHistory);
        }
    }

    class OutPatient : Patient, IMedicalRecord
    {
        private double consultationFee;

        public OutPatient(int id, string name, int age, double fee)
            : base(id, name, age)
        {
            consultationFee = fee;
        }

        public override double CalculateBill()
        {
            return consultationFee;
        }

        public void AddRecord(string diagnosis)
        {
            MedicalHistory = diagnosis;
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Record : " + MedicalHistory);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Patient[] patients = {
                new InPatient(1, "Rohan", 45, 5, 2000),
                new OutPatient(2, "Anita", 30, 500)
            };

            foreach (Patient patient in patients)
            {
                patient.GetPatientDetails();

                if (patient is IMedicalRecord record)
                {
                    record.AddRecord("General Checkup");
                    record.ViewRecords();
                }

                Console.WriteLine("Total Bill : " + patient.CalculateBill());
                Console.WriteLine("--------------------------");
            }
        }
    }
}
