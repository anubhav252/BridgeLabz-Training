using System;
using System.Data;
using HealthCareApp.Models;
using HealthCareApp.Services;

namespace HealthCareApp
{
    class Program
    {
        static void Main()
        {
            PatientService patientService = new PatientService();
            DoctorService doctorService = new DoctorService();
            AppointmentService appointmentService = new AppointmentService();
            BillingService billingService = new BillingService();

            int choice;

            do
            {
                Console.WriteLine("\n====== HEALTH CARE MANAGEMENT SYSTEM ======");
                Console.WriteLine("1. Register Patient");
                Console.WriteLine("2. Update Patient");
                Console.WriteLine("3. Search Patient");
                Console.WriteLine("4. Add Doctor");
                Console.WriteLine("5. Book Appointment");
                Console.WriteLine("6. Cancel Appointment");
                Console.WriteLine("7. View Daily Appointments");
                Console.WriteLine("8. Generate Bill");
                Console.WriteLine("9. Record Payment");
                Console.WriteLine("0. Exit");
                Console.Write("Enter Choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        RegisterPatient(patientService);
                        break;

                    case 2:
                        UpdatePatient(patientService);
                        break;

                    case 3:
                        SearchPatient(patientService);
                        break;

                    case 4:
                        AddDoctor(doctorService);
                        break;

                    case 5:
                        BookAppointment(appointmentService);
                        break;

                    case 6:
                        CancelAppointment(appointmentService);
                        break;

                    case 7:
                        DailySchedule(appointmentService);
                        break;

                    case 8:
                        GenerateBill(billingService);
                        break;

                    case 9:
                        RecordPayment(billingService);
                        break;

                    case 0:
                        Console.WriteLine("Exiting Application...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 0);
        }

        // ================= PATIENT =================

        static void RegisterPatient(PatientService service)
        {
            Patient p = new Patient();

            Console.Write("Patient Name: ");
            p.PatientName = Console.ReadLine();

            Console.Write("DOB (yyyy-mm-dd): ");
            p.DOB = DateTime.Parse(Console.ReadLine());

            Console.Write("Contact: ");
            p.Contact = Console.ReadLine();

            Console.Write("Address: ");
            p.PatientAddress = Console.ReadLine();

            Console.Write("Blood Group: ");
            p.BloodGroup = Console.ReadLine();

            service.RegisterPatient(p);
            Console.WriteLine("Patient Registered Successfully");
        }

        static void UpdatePatient(PatientService service)
        {
            Patient p = new Patient();

            Console.Write("Patient ID: ");
            p.PatientId = int.Parse(Console.ReadLine());

            Console.Write("New Name: ");
            p.PatientName = Console.ReadLine();

            Console.Write("New Contact: ");
            p.Contact = Console.ReadLine();

            Console.Write("New Address: ");
            p.PatientAddress = Console.ReadLine();

            service.UpdatePatient(p);
            Console.WriteLine("Patient Updated Successfully");
        }

        static void SearchPatient(PatientService service)
        {
            Console.Write("Enter Name / Contact / ID: ");
            string search = Console.ReadLine();

            DataTable dt = service.SearchPatient(search);

            Console.WriteLine("\n--- Search Results ---");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(
                    $"ID: {row["PatientId"]}, Name: {row["PatientName"]}, Contact: {row["Contact"]}");
            }
        }

        // ================= DOCTOR =================

        static void AddDoctor(DoctorService service)
        {
            Doctor d = new Doctor();

            Console.Write("Doctor Name: ");
            d.DoctorName = Console.ReadLine();

            Console.Write("Speciality ID: ");
            d.SpecialityId = int.Parse(Console.ReadLine());

            Console.Write("Contact: ");
            d.Contact = Console.ReadLine();

            Console.Write("Consultation Fee: ");
            d.ConsultationFee = decimal.Parse(Console.ReadLine());

            service.AddDoctor(d);
            Console.WriteLine(" Doctor Added Successfully");
        }

        // ================= APPOINTMENT =================

        static void BookAppointment(AppointmentService service)
        {
            Console.Write("Patient ID: ");
            int patientId = int.Parse(Console.ReadLine());

            Console.Write("Doctor ID: ");
            int doctorId = int.Parse(Console.ReadLine());

            Console.Write("Appointment Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            service.BookAppointment(patientId, doctorId, date);
            Console.WriteLine(" Appointment Booked");
        }

        static void CancelAppointment(AppointmentService service)
        {
            Console.Write("Appointment ID: ");
            int appointmentId = int.Parse(Console.ReadLine());

            service.CancelAppointment(appointmentId);
            Console.WriteLine(" Appointment Cancelled");
        }

        static void DailySchedule(AppointmentService service)
        {
            Console.Write("Enter Date (yyyy-mm-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            DataTable dt = service.DailySchedule(date);

            Console.WriteLine("\n--- Daily Schedule ---");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(
                    $"{row["AppointmentDate"]} | Patient: {row["PatientName"]} | Doctor: {row["DoctorName"]}");
            }
        }

        // ================= BILLING =================

        static void GenerateBill(BillingService service)
        {
            Console.Write("Visit ID: ");
            int visitId = int.Parse(Console.ReadLine());

            Console.Write("Total Amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            service.GenerateBill(visitId, amount);
            Console.WriteLine("Bill Generated");
        }

        static void RecordPayment(BillingService service)
        {
            Console.Write("Bill ID: ");
            int billId = int.Parse(Console.ReadLine());

            Console.Write("Payment Mode (Cash/Card/UPI): ");
            string mode = Console.ReadLine();

            service.RecordPayment(billId, mode);
            Console.WriteLine(" Payment Recorded");
        }
    }
}
