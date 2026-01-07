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
            Console.WriteLine("Enter Employee Type (FullTime / PartTime): ");
            employee.EmployeeType = Console.ReadLine();

            employees.Add(employee);
            return employee;    
        }
        // UC 1
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
            foreach(Employee employee in employees)
            {
                Console.WriteLine("Employee Id : " + employee.EmployeeId + "\nEmployee Name : " + employee.EmployeeName + "\nEmployee Salary : " + employee.EmployeeSalary );
            }   
        }

        // UC 2 

        private double wagePerHour = 20;

        public void CalculateWage()
        {
            if (employees.Count != 0)
            {
                foreach (Employee employee in employees)
                {
                    employee.EmployeeDailyWage = wagePerHour * 8;
                    Console.WriteLine(employee.EmployeeName +"'s daily Wage :"+ employee.EmployeeDailyWage);
                }
            }
            else { Console.WriteLine("Add employee first!"); }
        }

        //UC 3
        private double partTimeHour = 8;
        public void CalculatePartTimeWage()
        {
            if (employees.Count != 0)
            {
                foreach (Employee employee in employees)
                {
                    if (employee.EmployeeType.Equals("PartTime", StringComparison.OrdinalIgnoreCase))
                    {
                        employee.EmployeeDailyWage = partTimeHour * wagePerHour;
                        Console.WriteLine(employee.EmployeeName +
                            "'s Part Time Daily Wage : " + employee.EmployeeDailyWage);
                    }
                }
            }
            else
            {
                Console.WriteLine("Add employee first!");
            }
        }

        //UC 5
        private const int WORKING_DAYS = 20;

        public void CalculateMonthlyWage()
        {
            if (employees.Count != 0)
            {
                foreach (Employee employee in employees)
                {
                    if (employee.EmployeeDailyWage > 0)
                    {
                        double monthlyWage = employee.EmployeeDailyWage * WORKING_DAYS;
                        Console.WriteLine(employee.EmployeeName +"'s Monthly Wage : " + monthlyWage);
                    }
                    else
                    {
                        Console.WriteLine("Calculate daily wage first for " + employee.EmployeeName);
                    }
                }
            }
            else
            {
                Console.WriteLine("Add employee first!");
            }
        }


    }
}
