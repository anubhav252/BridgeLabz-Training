using System;
using System.IO;

class StudentData
{
    static void Main()
    {
        string filePath = "student.txt";

        try
        {
            Console.Write("Enter Roll Number: ");
            int roll = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter GPA: ");
            double gpa = double.Parse(Console.ReadLine());

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(roll);
                writer.Write(name);
                writer.Write(gpa);
            }

            Console.WriteLine("\nData stored successfully.\n");

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                int r = reader.ReadInt32();
                string n = reader.ReadString();
                double g = reader.ReadDouble();

                Console.WriteLine("Retrieved Student Data:");
                Console.WriteLine("Roll Number: " + r);
                Console.WriteLine("Name: " + n);
                Console.WriteLine("GPA: " + g);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
