using System;

class Student{
    public static string UniversityName = "GLA University";
    private static int totalStudents = 0;

    public readonly int RollNumber;
    private string Name;
    private string Grade;

    public Student(int RollNumber, string Name, string Grade){
        this.RollNumber = RollNumber;
        this.Name = Name;
        this.Grade = Grade;
        totalStudents++;
    }

    public static void DisplayTotalStudents(){
        Console.WriteLine("Total Students Enrolled: " + totalStudents);
    }

    public void UpdateGrade(string newGrade){
        Grade = newGrade;
    }

    public void DisplayStudentDetails(){
        Console.WriteLine("University Name : " + UniversityName);
        Console.WriteLine("Roll Number     : " + RollNumber);
        Console.WriteLine("Name            : " + Name);
        Console.WriteLine("Grade           : " + Grade);
        Console.WriteLine("------------------------------");
    }
}

class TestStudent{
    static void Main(string[] args){
        Student s1 = new Student(101, "Anubhav", "A");
        Student s2 = new Student(102, "Rohit", "B");

        if (s1 is Student){
            s1.DisplayStudentDetails();
            s1.UpdateGrade("A+");
        }

        if (s2 is Student){
            s2.DisplayStudentDetails();
        }

        Console.WriteLine("\nAfter Grade Update:\n");
        s1.DisplayStudentDetails();

        Student.DisplayTotalStudents();
    }
}
