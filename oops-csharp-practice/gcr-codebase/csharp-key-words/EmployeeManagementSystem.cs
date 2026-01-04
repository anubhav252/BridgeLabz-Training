using System;

class Employee{
    public static string CompanyName = "BridgeLabz Solutions";
    private static int totalEmployees = 0;

    public readonly int Id;
    private string Name;
    private string Designation;

    public Employee(int Id, string Name, string Designation){
        this.Id = Id;
        this.Name = Name;
        this.Designation = Designation;
        totalEmployees++;
    }

    public static void GetTotalEmployees(){
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    public void DisplayEmployeeDetails(){
        Console.WriteLine("Company Name : " + CompanyName);
        Console.WriteLine("Employee ID  : " + Id);
        Console.WriteLine("Name         : " + Name);
        Console.WriteLine("Designation  : " + Designation);
        Console.WriteLine("------------------------------");
    }
}

class EmployeeManagementSystem{
    static void Main(string[] args){
        Employee emp1 = new Employee(101, "Anubhav", "Software Engineer");
        Employee emp2 = new Employee(102, "Rohit", "Team Lead");

        if (emp1 is Employee)
        {
            emp1.DisplayEmployeeDetails();
        }

        if (emp2 is Employee)
        {
            emp2.DisplayEmployeeDetails();
        }

        Employee.GetTotalEmployees();
    }
}
