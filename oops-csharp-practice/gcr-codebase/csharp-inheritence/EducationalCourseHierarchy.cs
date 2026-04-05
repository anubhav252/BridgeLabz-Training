using System;

class Course{
    protected string CourseName;
    protected int Duration; 

    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine("Course Name : " + CourseName);
        Console.WriteLine("Duration    : " + Duration + " hours");
    }
}

class OnlineCourse : Course{
    protected string Platform;
    protected bool IsRecorded;

    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Platform    : " + Platform);
        Console.WriteLine("Recorded    : " + IsRecorded);
    }
}

class PaidOnlineCourse : OnlineCourse{
    private double Fee;
    private double Discount;

    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Fee         : " + Fee);
        Console.WriteLine("Discount    : " + Discount + "%");
        Console.WriteLine("Final Price : " + (Fee - (Fee * Discount / 100)));
    }
}

class EducationalCourseHierarchy{
    static void Main(string[] args){
        Course c1 = new Course("C# Basics", 30);
        Course c2 = new OnlineCourse("Java Programming", 45, "Udemy", true);
        Course c3 = new PaidOnlineCourse("Advanced C#", 60, "Coursera", true, 5000, 20);

        Console.WriteLine("----- Course 1 -----");
        c1.DisplayDetails();

        Console.WriteLine("\n----- Course 2 -----");
        c2.DisplayDetails();

        Console.WriteLine("\n----- Course 3 -----");
        c3.DisplayDetails();
    }
}
