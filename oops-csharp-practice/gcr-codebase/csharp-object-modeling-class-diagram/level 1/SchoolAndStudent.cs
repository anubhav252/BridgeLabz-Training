using System;
using System.Collections.Generic;

class Course{
    public string CourseName;
    private List<Student> enrolledStudents;

    public Course(string courseName){
        CourseName = courseName;
        enrolledStudents = new List<Student>();
    }

    public void AddStudent(Student student){
        enrolledStudents.Add(student);
    }

    public void DisplayEnrolledStudents(){
        Console.WriteLine("Course: " + CourseName);
        foreach (Student student in enrolledStudents){
            Console.WriteLine("  Student: " + student.Name);
        }
    }
}

class Student{
    public string Name;
    private List<Course> courses;

    public Student(string name){
        Name = name;
        courses = new List<Course>();
    }

    public void EnrollCourse(Course course){
        courses.Add(course);
        course.AddStudent(this);
    }

    public void DisplayCourses(){
        Console.WriteLine("Student: " + Name);
        foreach (Course course in courses){
            Console.WriteLine("  Enrolled in: " + course.CourseName);
        }
    }
}

class School{
    public string SchoolName;
    private List<Student> students;

    public School(string schoolName){
        SchoolName = schoolName;
        students = new List<Student>();
    }

    public void AddStudent(Student student){
        students.Add(student);
    }

    public void DisplayStudents(){
        Console.WriteLine("School: " + SchoolName);
        foreach (Student student in students){
            Console.WriteLine("Student: " + student.Name);
        }
    }
}

class SchoolAndStudent{
    static void Main(string[] args){
        School school = new School("Green Valley School");

        Student s1 = new Student("Anubhav");
        Student s2 = new Student("Rohit");

        Course c1 = new Course("Mathematics");
        Course c2 = new Course("Computer Science");

        school.AddStudent(s1);
        school.AddStudent(s2);

        s1.EnrollCourse(c1);
        s1.EnrollCourse(c2);

        s2.EnrollCourse(c1);

        Console.WriteLine();
        s1.DisplayCourses();
        Console.WriteLine();
        s2.DisplayCourses();

        Console.WriteLine();
        c1.DisplayEnrolledStudents();
        Console.WriteLine();
        c2.DisplayEnrolledStudents();
    }
}
