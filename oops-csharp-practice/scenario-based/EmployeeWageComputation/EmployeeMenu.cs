using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    sealed class EmployeeMenu
    {
        private IEmployee employeeChoice;
        public void Menu()
        {
            employeeChoice = new EmployeeUtilityImpl();
            Console.WriteLine("Welcome to the Employee Wage Computation Program" );
            while (true) ///// UC 4 Using SwitchCase
            {
                Console.WriteLine("enter corresponding no. for your task \n1. Add Employee \n2. Attendance \n3. Display employee details \n4. Calculate Employee Wage \n5. Calculate Part Time Employee Wage \n6. Calculate Monthly Wage \n7. Calculate Wage Till Condition \n8. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        employeeChoice.AddEmployee();
                        break;
                    case 2:
                        employeeChoice.EmployeeAttendance();
                        break;
                    case 3:
                        employeeChoice.DisplayDetails();
                        break;
                    case 4:                                   //UC 2
                        employeeChoice.CalculateWage();
                        break;
                    case 5:                                   //UC 3
                        employeeChoice.CalculatePartTimeWage();
                        break;
                    case 6:                                  // UC 5
                        employeeChoice.CalculateMonthlyWage();
                        break;
                    case 7:                                  // UC 6
                        employeeChoice.CalculateWageTillCondition();
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine("invalid");
                        break;
                }
            }
        }
    }
}
