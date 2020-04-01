using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class EmployeeWages
    {
        int PRESENT = 0;
        public bool employeeAttendance()
            {
                Random Number= new Random();
                return Number.Next(0, 2) == PRESENT ? true : false;
            }

        public int dailyEmployeeWages(int workingHours, int Wage)
        {
           return workingHours* Wage;
        }
            
    }
}
