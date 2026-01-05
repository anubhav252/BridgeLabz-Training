using System;
namespace HospitalManagementSystem
{
    interface IPayable {
         double CalculateBill();
    }
   internal class Doctor
    {
        public string doctorName {get;set;}
        public Patient patient { get; set; }

        public Doctor(string doctorName,Patient patient){
            this.doctorName = doctorName;
            this.patient = patient;
           
        }

        public void DisplayDetails() {
            Console.WriteLine("Doctor Name : "+doctorName);
            patient.DisplayDetails();
            Bill bill = new Bill(patient);
            bill.GenerateBill();

        }
    }

    internal class Patient:IPayable { 
        public string patientName { get; set; }
        public double roomPrice {  get; set; }

        public Patient(string patientName, double roomPrice)
        {
            this.patientName = patientName;
            this.roomPrice = roomPrice;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Patient Name" + patientName + "\nRoom Price Selected" + roomPrice);
        }

        public virtual double CalculateBill()
        {
            return roomPrice;
        }
    }

    internal class InPatient : Patient { 
        DateTime inDate { get; set; }
        int noOfDays { get; set; }
        public InPatient(string patientName, double roomPrice, DateTime inDate,int noOfDays) : base(patientName, roomPrice) { 
            this.inDate = inDate;
            this.noOfDays = noOfDays;
        }

        public override void DisplayDetails() {
            Console.WriteLine("Patient " + patientName + " admitted on " + inDate+" for "+noOfDays+" days ");
        }

        public override double CalculateBill()
        {
            return roomPrice * noOfDays;
        }
    }

    internal class OutPatient : Patient { 
        DateTime outDate { get;set;}
        double doctorsFee { get; set; }
        public OutPatient(string patientName,double roomPrice,DateTime outDate,double doctorsFee) : base(patientName, roomPrice) { 
            this.outDate = outDate;
            this.doctorsFee = doctorsFee;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Patient " + patientName + " visited on " + outDate);
        }

        public override double CalculateBill()
        {
            return doctorsFee;
        }
    }

    
    internal class Bill {
        private IPayable payable;

        public Bill(IPayable payable) {
            this.payable = payable;
        }

        public void GenerateBill() {
            double amount = payable.CalculateBill();
            Console.WriteLine("total bill amount : "+amount);
        }
    }

    internal class HospitalManagement {
        static void Main(string[] args) {
            Patient patient1 = new InPatient("sam",2500,DateTime.Now.AddDays(-6),5);
            Doctor doctor1=new Doctor("dr.mehta",patient1);

            doctor1.DisplayDetails();

            Patient patient2 = new OutPatient("nick", 3000, DateTime.Now, 700);
            Doctor doctor2=new Doctor("dr. gupta",patient2);
            doctor2.DisplayDetails();
        }
    }
}


