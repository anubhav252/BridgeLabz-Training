using System;

class Employee{
    protected string Name;
    protected int Id;
    protected double Salary;

    public Employee(string name, int id, double salary){
        Name = name;
        Id = id;
        Salary = salary;
    }

    public virtual void DisplayDetails(){
        Console.WriteLine("Name   : " + Name);
        Console.WriteLine("ID     : " + Id);
        Console.WriteLine("Salary : " + Salary);
    }
}

class Manager : Employee{
    private int TeamSize;

    public Manager(string name, int id, double salary, int teamSize)
        : base(name, id, salary){
        TeamSize = teamSize;
    }

    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Team Size : " + TeamSize);
        Console.WriteLine("--------------------------");
    }
}

class Developer : Employee{
    private string ProgrammingLanguage;

    public Developer(string name, int id, double salary, string programmingLanguage)
        : base(name, id, salary){
        ProgrammingLanguage = programmingLanguage;
    }

    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Language  : " + ProgrammingLanguage);
        Console.WriteLine("--------------------------");
    }
}

class Intern : Employee{
    private string InternshipDuration;

    public Intern(string name, int id, double salary, string internshipDuration)
        : base(name, id, salary){
        InternshipDuration = internshipDuration;
    }

    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Duration  : " + InternshipDuration);
        Console.WriteLine("--------------------------");
    }
}

class EmployeeSystem{
    static void Main(string[] args){
        Employee e1 = new Manager("Anubhav", 101, 80000, 10);
        Employee e2 = new Developer("Rohit", 102, 60000, "C#");
        Employee e3 = new Intern("Amit", 103, 15000, "6 Months");

        e1.DisplayDetails();
        e2.DisplayDetails();
        e3.DisplayDetails();
    }
}
