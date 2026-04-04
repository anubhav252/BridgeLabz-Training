using System;
using System.Collections.Generic;

class Course{
    public string CourseName;
    private Professor assignedProfessor;
    private List<Student> enrolledStudents;

    public Course(string courseName)
    {
        CourseName = courseName;
        enrolledStudents = new List<Student>();
    }

    public void AssignProfessor(Professor professor)
    {
        assignedProfessor = professor;
        Console.WriteLine(professor.Name + " assigned to course " + CourseName);
    }

    public void AddStudent(Student student)
    {
        enrolledStudents.Add(student);
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine("\nCourse: " + CourseName);
        Console.WriteLine("Professor: " + (assignedProfessor != null ? assignedProfessor.Name : "Not Assigned"));

        Console.WriteLine("Students Enrolled:");
        foreach (Student s in enrolledStudents)
        {
            Console.WriteLine("  " + s.Name);
        }
    }
}

class Student{
    public string Name;
    private List<Course> courses;

    public Student(string name)
    {
        Name = name;
        courses = new List<Course>();
    }

    public void EnrollCourse(Course course)
    {
        courses.Add(course);
        course.AddStudent(this);
        Console.WriteLine(Name + " enrolled in " + course.CourseName);
    }

    public void ViewCourses()
    {
        Console.WriteLine("\nCourses enrolled by " + Name + ":");
        foreach (Course c in courses)
        {
            Console.WriteLine("  " + c.CourseName);
        }
    }
}

class Professor
{
    public string Name;

    public Professor(string name)
    {
        Name = name;
    }

    public void AssignToCourse(Course course)
    {
        course.AssignProfessor(this);
    }
}

class University
{
    public string UniversityName;
    public List<Student> Students;
    public List<Professor> Professors;
    public List<Course> Courses;

    public University(string universityName)
    {
        UniversityName = universityName;
        Students = new List<Student>();
        Professors = new List<Professor>();
        Courses = new List<Course>();
    }
}

class UniversitySystem{
    static void Main(string[] args){
        University uni = new University("Global Tech University");

        Student s1 = new Student("Anubhav");
        Student s2 = new Student("Rohit");

        Professor p1 = new Professor("Dr. Sharma");
        Professor p2 = new Professor("Dr. Mehta");

        Course c1 = new Course("Computer Science");
        Course c2 = new Course("Mathematics");

        uni.Students.Add(s1);
        uni.Students.Add(s2);
        uni.Professors.Add(p1);
        uni.Professors.Add(p2);
        uni.Courses.Add(c1);
        uni.Courses.Add(c2);

        p1.AssignToCourse(c1);
        p2.AssignToCourse(c2);

        s1.EnrollCourse(c1);
        s1.EnrollCourse(c2);
        s2.EnrollCourse(c1);

        s1.ViewCourses();
        s2.ViewCourses();

        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();
    }
}
