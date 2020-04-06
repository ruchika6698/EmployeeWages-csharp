using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class EmployeeWages
    {
        /// <summary>
        /// constants Same for every Employee
        /// </summary
        public const int WAGE_PER_HOUR = 20;
        public const int FULL_TIME_HOUR = 8;
        public const int PART_TIME_HOUR = 4;
        public const int NO_WAGE = 0;
        private const int PRESENT = 0;
        private const int MONTHLY_DAYS = 20;
        private const int MONTHLY_WORKING_HOURS = 100;

        /// <summary>
        /// Variale declaration
        /// </summary
        private static bool isEmployeePresent;
        private static int wageForDay;
        private static int workHours;
        private static int empType;
        private int workinghrsForMonth = 0;
        private int days = 0;
        private int FULL_TIME;
        private int PART_TIME;
        private int WAGES_PER_HOUR;

        /// <summary>
        /// Constructor 
        /// </summary
        public EmployeeWages(int FULL_TIME, int PART_TIME, int WAGES_PER_HOUR)
        {
            this.FULL_TIME = FULL_TIME;
            this.PART_TIME = PART_TIME;
            this.WAGES_PER_HOUR = WAGES_PER_HOUR;
        }

        /// <summary>
        /// Method to check Employee is present or absent
        /// </summary
        public bool employeeAttendance()
        {
            Random Number= new Random();
            return Number.Next(0, 1) == PRESENT;
        }

        /// <summary>
        /// Method to check Daily employee Wages
        /// </summary
        public int dailyEmployeeWages(int workingHours, int Wage)
        {
           return workingHours* Wage;
        }

        /// <summary>
        /// Method to check Working hours for day
        /// </summary
        public int workingHoursForDay(int workinghrsForMonth)
        {
            Random randomNum = new Random();
            empType = randomNum.Next(0, 1);
            switch (empType) 
            {
                case 0:
                    workHours = FULL_TIME_HOUR;
                    break;
                case 1:
                    workHours = PART_TIME_HOUR;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            if ((MONTHLY_WORKING_HOURS - workinghrsForMonth) < FULL_TIME_HOUR)
            {
                workHours = PART_TIME_HOUR;
            }
            return workHours;
        }

        /// <summary>
        /// Method to calculate Monthly wages
        /// </summary
        public int monthlyWage()
        {
            int employeeMonthlyWage = 0;
            int daysWorkedInMonth = 0;
            while (daysWorkedInMonth < MONTHLY_DAYS && workinghrsForMonth < MONTHLY_WORKING_HOURS && days <= 20)
            {
                
                isEmployeePresent = this.employeeAttendance();          //Employee Present or Absent
                if (isEmployeePresent == true)
                {
                    Random Number = new Random();
                    empType = Number.Next(0, 2);
                    workHours = workingHoursForDay(workinghrsForMonth);
                    wageForDay = this.dailyEmployeeWages(workHours, WAGE_PER_HOUR);   
                    daysWorkedInMonth++;
                    workinghrsForMonth += workHours;
                }
                else
                {
                    wageForDay = NO_WAGE;
                }
                days++;
                employeeMonthlyWage += wageForDay;
            }
            return employeeMonthlyWage;
        }
    }
}