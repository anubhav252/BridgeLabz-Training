using System;

class Course{
    private string courseName;
    private int duration;
    private double fee;

    private static string instituteName ;

    public Course(string courseName, int duration, double fee){
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
		instituteName = "Tech Institute";
    }

    public void DisplayCourseDetails(){
        Console.WriteLine("Institute Name : " + instituteName);
        Console.WriteLine("Course Name    : " + courseName);
        Console.WriteLine("Duration       : " + duration + " months");
        Console.WriteLine("Fee            : " + fee);
    }

    public static void UpdateInstituteName(string newInstituteName){
        instituteName = newInstituteName;
    }
}

class CourseManagement{
    static void Main(string[] args){
        Course course1 = new Course("C# Programming", 6, 15000);
        Course course2 = new Course("Java Development", 5, 14000);
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
        Course.UpdateInstituteName("Global Tech Academy");
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
    }
}
