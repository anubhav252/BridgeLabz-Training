using System;

class Person{
    protected string Name;
    protected int Age;

    public Person(string name, int age){
        Name = name;
        Age = age;
    }

    public virtual void DisplayPersonDetails(){
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Age  : " + Age);
    }
}

class Teacher : Person{
    private string Subject;

    public Teacher(string name, int age, string subject)
        : base(name, age){
        Subject = subject;
    }

    public void DisplayRole(){
        Console.WriteLine("Role    : Teacher");
        DisplayPersonDetails();
        Console.WriteLine("Subject : " + Subject);
        Console.WriteLine("--------------------------");
    }
}

class Student : Person{
    private string Grade;

    public Student(string name, int age, string grade)
        : base(name, age){
        Grade = grade;
    }

    public void DisplayRole(){
        Console.WriteLine("Role  : Student");
        DisplayPersonDetails();
        Console.WriteLine("Grade : " + Grade);
        Console.WriteLine("--------------------------");
    }
}

class Staff : Person{
    private string Department;

    public Staff(string name, int age, string department)
        : base(name, age){
        Department = department;
    }

    public void DisplayRole(){
        Console.WriteLine("Role       : Staff");
        DisplayPersonDetails();
        Console.WriteLine("Department : " + Department);
        Console.WriteLine("--------------------------");
    }
}

class SchoolSystem{
    static void Main(string[] args){
        Teacher t = new Teacher("Anubhav", 35, "Mathematics");
        Student s = new Student("Rohit", 16, "10th Grade");
        Staff st = new Staff("Amit", 40, "Administration");

        t.DisplayRole();
        s.DisplayRole();
        st.DisplayRole();
    }
}
