using System;
using System.Collections.Generic;

class Employee{
    public string Name;

    public Employee(string name){
        Name = name;
    }

    public void DisplayEmployee(){
        Console.WriteLine("    Employee: " + Name);
    }
}

class Department{
    public string DepartmentName;
    private List<Employee> employees;

    public Department(string departmentName){
        DepartmentName = departmentName;
        employees = new List<Employee>();
    }

    public void AddEmployee(string employeeName){
        employees.Add(new Employee(employeeName));
    }

    public void DisplayDepartment(){
        Console.WriteLine("  Department: " + DepartmentName);
        foreach (Employee emp in employees){
            emp.DisplayEmployee();
        }
    }
}

class Company{
    public string CompanyName;
    private List<Department> departments;

    public Company(string companyName){
        CompanyName = companyName;
        departments = new List<Department>();
    }

    public void AddDepartment(Department department){
        departments.Add(department);
    }

    public void DisplayCompany(){
        Console.WriteLine("Company: " + CompanyName);
        foreach (Department dept in departments){
            dept.DisplayDepartment();
        }
    }
}

class CompanyAndDepartment{
    static void Main(string[] args){
        Company company = new Company("TechCorp");

        Department it = new Department("IT");
        it.AddEmployee("Anubhav");
        it.AddEmployee("Rohit");

        Department hr = new Department("HR");
        hr.AddEmployee("Amit");

        company.AddDepartment(it);
        company.AddDepartment(hr);

        company.DisplayCompany();

        company = null;
        Console.WriteLine("\nCompany deleted. Departments and Employees no longer exist.");
    }
}
