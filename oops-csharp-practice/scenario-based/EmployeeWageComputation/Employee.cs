using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        private long employeeId;
        private string employeeName;
        private double employeeSalary;
        private double employeeDailyWage;// UC 2
        public long EmployeeId
        {
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
            set
            {
                employeeName = value;
            }
        }
        public double EmployeeSalary
        {
            get
            {
                return employeeSalary;
            }
            set
            {
                employeeSalary = value;
            }
        }

        public double EmployeeDailyWage // UC 2
        {
            get { return employeeDailyWage; }
            set
            {
                if (value > 0)
                {
                    employeeDailyWage = value;
                }
            }
        }
        public override string ToString()
        {
            return ("Employee Id : "+employeeId+"\nEmployee Name : "+employeeName+"\nEmployee Salary : "+employeeSalary);
        }  
    }
}
