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
        void EmployeeAttendance();

        void DisplayDetails();
    }
}
