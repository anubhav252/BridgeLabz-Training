using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal interface IEmployee
    {
        Employee AddEmployee();
        void EmployeeAttendance();// UC 1

        void DisplayDetails();// UC 1

        void CalculateWage(); //UC 2
        void CalculatePartTimeWage(); // UC 3

        void CalculateMonthlyWage();   // UC 5

        void CalculateWageTillCondition();   // UC 6



    }
}
