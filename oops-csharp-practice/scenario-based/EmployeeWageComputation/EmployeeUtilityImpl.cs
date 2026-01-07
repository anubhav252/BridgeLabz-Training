using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeUtilityImpl:IEmployee
    {
        private List<Employee> employees = new List<Employee>();
        Random forAttendance = new Random();
        private Employee employee;
        public Employee AddEmployee()
        {
            employee = new Employee();
            Console.WriteLine("Enter Employee Id : ");
            employee.EmployeeId = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee name :");
            employee.EmployeeName = Console.ReadLine();

            employees.Add(employee);
            return employee;    
        }

        public void EmployeeAttendance()
        {
            if (employees.Count != 0)
            {
                long noChecker=forAttendance.Next(1,100000);
                Console.WriteLine(noChecker);
                Console.WriteLine("Enter the no. on your screen : ");
                long employeeInput=long.Parse(Console.ReadLine());
          
                if (employeeInput == noChecker)
                {
                    Console.WriteLine("Present");
                }
                else
                {
                    Console.WriteLine("Absent");
                }
            }
            else {
                Console.WriteLine("Add employee first "); 
            }
        }

        public void DisplayDetails()
        {
            foreach(Employee emp in employees)
            {
                Console.WriteLine("Employee Id : " + emp.EmployeeId + "\nEmployee Name : " + emp.EmployeeName + "\nEmployee Salary : " + emp.EmployeeSalary );
            }   
        }
    }
}
