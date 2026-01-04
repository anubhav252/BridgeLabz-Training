using System;
using System.Collections.Generic;

class Faculty{
    public string Name;
    public string Subject;

    public Faculty(string name, string subject){
        Name = name;
        Subject = subject;
    }

    public void DisplayFaculty(){
        Console.WriteLine("Faculty Name : " + Name + ", Subject : " + Subject);
    }
}

class Department{
    public string DepartmentName;

    public Department(string departmentName){
        DepartmentName = departmentName;
    }

    public void DisplayDepartment(){
        Console.WriteLine("Department : " + DepartmentName);
    }
}

class University{
    public string UniversityName;
    private List<Department> departments;
    private List<Faculty> faculties;

    public University(string universityName){
        UniversityName = universityName;
        departments = new List<Department>();
        faculties = new List<Faculty>();
    }

    public void AddDepartment(string departmentName){
        departments.Add(new Department(departmentName));
    }

    public void AddFaculty(Faculty faculty){
        faculties.Add(faculty);
    }

    public void DisplayUniversityDetails(){
        Console.WriteLine("University : " + UniversityName);

        Console.WriteLine("\nDepartments:");
        foreach (Department dept in departments){
            dept.DisplayDepartment();
        }

        Console.WriteLine("\nFaculty Members:");
        foreach (Faculty faculty in faculties){
            faculty.DisplayFaculty();
        }
    }
}

class UniversityAndDepartment{
    static void Main(string[] args){
        Faculty f1 = new Faculty("Dr. Anubhav", "Computer Science");
        Faculty f2 = new Faculty("Dr. Rohit", "Mathematics");

        University uni = new University("Global Tech University");

        uni.AddDepartment("Engineering");
        uni.AddDepartment("Science");

        uni.AddFaculty(f1);
        uni.AddFaculty(f2);

        uni.DisplayUniversityDetails();

        uni = null;
        Console.WriteLine("\nUniversity deleted. Departments are gone, Faculty still exists.\n");

        f1.DisplayFaculty();
        f2.DisplayFaculty();
    }
}
