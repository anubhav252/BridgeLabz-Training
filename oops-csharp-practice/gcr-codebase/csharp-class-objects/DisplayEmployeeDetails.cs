using System;
class Employee{
	private string Name;
	private int Id;
	private long Salary;
	
	public Employee(int id,string name,long salary){
		this.Name=name;
		this.Id=id;
		this.Salary=salary;
	}
	
	public void DisplayDetails(){
		Console.WriteLine("Employee Id : "+Id);
		Console.WriteLine("Employee Name : "+Name);
		Console.WriteLine("Employee Salary : "+Salary);
	}
}

class DisplayEmployeeDetails{
	static void Main(string[] args){
		
		Employee obj=new Employee(1234,"Sam",600000);
		
		Console.WriteLine("Employee Detais are : ");
		obj.DisplayDetails();
	}
}