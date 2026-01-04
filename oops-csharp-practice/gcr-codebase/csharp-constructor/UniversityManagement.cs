using System;

class Student{
    public int rollNumber;
    protected string name;
    private double cgpa;

    public Student(int rollNumber, string name, double cgpa){
        this.rollNumber = rollNumber;
        this.name = name;
        this.cgpa = cgpa;
    }

    public double GetCGPA(){
        return cgpa;
    }

    public void SetCGPA(double newCgpa){
        cgpa = newCgpa;
    }

    public void DisplayStudent(){
        Console.WriteLine("Roll Number : " + rollNumber);
        Console.WriteLine("Name        : " + name);
        Console.WriteLine("CGPA        : " + cgpa);
        Console.WriteLine("------------------------");
    }
}

class PostgraduateStudent : Student{
    private string specialization;

    public PostgraduateStudent(int rollNumber, string name, double cgpa, string specialization)
        : base(rollNumber, name, cgpa){
        this.specialization = specialization;
    }

    public void DisplayPostgraduateStudent(){
        Console.WriteLine("Roll Number     : " + rollNumber);
        Console.WriteLine("Name            : " + name);
        Console.WriteLine("Specialization  : " + specialization);
        Console.WriteLine("CGPA            : " + GetCGPA());
        Console.WriteLine("------------------------");
    }
}

class UniversityManagement{
    static void Main(string[] args){
        Student s1 = new Student(101, "Anubhav", 8.2);
        s1.DisplayStudent();

        s1.SetCGPA(8.6);
        Console.WriteLine("Updated CGPA: " + s1.GetCGPA());
        Console.WriteLine();

        PostgraduateStudent pg = new PostgraduateStudent(201, "Rohit", 8.8, "Computer Science");
        pg.DisplayPostgraduateStudent();
    }
}
