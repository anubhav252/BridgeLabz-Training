using System;    
interface IDepartment
{
    void AssignDepartment(string dept);
    void GetDepartmentDetails();
}
abstract class Employee :IDepartment
{
    private int employeeId;
    private string employeeName;
    private double baseSalary;
    protected string department;
    public int EmployeeId {
        get
        {
            return employeeId;
        }
        set
        {
            employeeId = value;
        }
    }
    public string EmployeeName
    {
        get
        {
            return employeeName;
        }
        set { 
            employeeName = value;
        }
    }
    public double BaseSalary
    {
        get
        {
            return baseSalary;
        }
        set
        {
            if (value > 0) {
                baseSalary = value;
            }
            else { 
                Console.WriteLine("invalid enter again");
            }
        }
    }
    public Employee(int employeeId,string employeeName,double baseSalary) {
        this.employeeId = employeeId;       
        this.employeeName = employeeName;
        this.baseSalary = baseSalary;
    }
    public abstract void CalculateSalary();
    public void AssignDepartment(string dept)
    {
        department = dept;
    }
    public void GetDepartmentDetails()
    {
        Console.WriteLine("Department : "+department);
    }
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Employee Id : " + employeeId + "\nEmployee Name : " + employeeName + "\nBase Salary : " + baseSalary);
    }
}


class FullTimeEmployee:Employee
{
   
    public FullTimeEmployee(int employeeId, string employeeName, double baseSalary):base(employeeId, employeeName, baseSalary)
    {
          
    }
    public override void CalculateSalary()
    {
        double taxedSalary = BaseSalary - BaseSalary * 0.12;
        Console.WriteLine("employee exact salary = " + taxedSalary);
    }
}



class PartTimeEmployee : Employee
{
    private double workinghours;
    double salary;
    public PartTimeEmployee(double workinghours,int employeeId, string employeeName, double baseSalary) : base(employeeId, employeeName, baseSalary)
    {
        this.workinghours = workinghours;
    }
    public override void CalculateSalary()
    {
        salary = workinghours*BaseSalary;
        Console.WriteLine("employee exact salary = " + salary);
    }
}



class ManagementSystem
{
    static void Main(string[] args)
    {
        Employee[] employees = { new FullTimeEmployee(121, "sam", 30000), new FullTimeEmployee(122, "anubhav", 40000), new PartTimeEmployee(5, 123, "nick", 1000) };
        foreach (Employee employee in employees) {
            if (employee is FullTimeEmployee) {
                employee.AssignDepartment("IT");
                employee.DisplayDetails();
                employee.CalculateSalary();
                employee.GetDepartmentDetails();
                Console.WriteLine("---------------------------------------");
            }
            if(employee is PartTimeEmployee)
            {
                employee.AssignDepartment("sales and services");
                employee.DisplayDetails();
                employee.CalculateSalary();
                employee.GetDepartmentDetails();
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}

