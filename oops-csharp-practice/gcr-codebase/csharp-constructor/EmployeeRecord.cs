using System;

class Employee{
    public int employeeID;
    protected string department;
    private double salary;

    public Employee(int employeeID, string department, double salary){
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }

    public double GetSalary(){
        return salary;
    }

    public void UpdateSalary(double newSalary){
        if (newSalary > 0)
            salary = newSalary;
    }

    public void DisplayEmployee(){
        Console.WriteLine("Employee ID : " + employeeID);
        Console.WriteLine("Department  : " + department);
        Console.WriteLine("Salary      : " + salary);
        Console.WriteLine("----------------------------");
    }
}

class Manager : Employee{
    private string role;

    public Manager(int employeeID, string department, double salary, string role)
        : base(employeeID, department, salary){
        this.role = role;
    }

    public void DisplayManager(){
        Console.WriteLine("Employee ID : " + employeeID);
        Console.WriteLine("Department  : " + department);
        Console.WriteLine("Role        : " + role);
        Console.WriteLine("Salary      : " + GetSalary());
        Console.WriteLine("----------------------------");
    }
}

class EmployeeRecord{
    static void Main(string[] args){
        Employee emp = new Employee(101, "IT", 50000);
        emp.DisplayEmployee();

        emp.UpdateSalary(55000);
        Console.WriteLine("Updated Salary: " + emp.GetSalary());
        Console.WriteLine();

        Manager mgr = new Manager(201, "HR", 80000, "Team Lead");
        mgr.DisplayManager();
    }
}
