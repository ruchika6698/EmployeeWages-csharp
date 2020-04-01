using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class EmployeeWages
    {
        public static int WAGE_PER_HOUR = 20;
        public static int FULL_TIME_HOUR = 8;
        public static int PART_TIME_HOUR = 4;
        public static int NO_WAGE = 0;
        private int PRESENT = 0;
        private int MONTHLY_DAYS = 20;

        private static bool isEmployeePresent;
        private static int wageForDay;
        private static int workHours;
        private static int empType;
        public bool employeeAttendance()
            {
                Random Number= new Random();
                return Number.Next(0, 2) == PRESENT ? true : false;
            }

        public int dailyEmployeeWages(int workingHours, int Wage)
        {
           return workingHours* Wage;
        }


        public int monthlyWage()
        {
            int employeeMonthlyWage = 0;
            int daysWorkedInMonth = 0;
            while (daysWorkedInMonth < MONTHLY_DAYS)
            {
                //Employee Present or Absent
                isEmployeePresent = this.employeeAttendance();
                if (isEmployeePresent == true)
                {
                    Random Number = new Random();
                    empType = Number.Next(0, 2);
                    switch (empType)
                    {
                        case 1:
                            workHours = FULL_TIME_HOUR;
                            break;
                        case 2:
                            workHours = PART_TIME_HOUR;
                            break;
                        default:
                            Console.WriteLine("Wrong choice!");
                            break;
                    }
                    //dailyWage
                    wageForDay = emp.dailyEmployeeWages(workHours, WAGE_PER_HOUR);
                }
                else
                {
                    wageForDay = NO_WAGE;
                }
            }
            // Caclulating monthly wage
            employeeMonthlyWage += wageForDay;  
            daysWorkedInMonth++;
        }
            return employeeMonthlyWage;

    }
}
