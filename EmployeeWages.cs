﻿using System;
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
        private int MONTHLY_WORKING_HOURS = 100;

        private static bool isEmployeePresent;
        private static int wageForDay;
        private static int workHours;
        private static int empType;
        private int workinghrsForMonth = 0;
        private int days = 0;


        
        public bool employeeAttendance()
        {
            Random Number= new Random();
            return Number.Next(0, 2) == PRESENT ? true : false;
        }

        public int dailyEmployeeWages(int workingHours, int Wage)
        {
           return workingHours* Wage;
        }

        public int workingHoursForDay(int workinghrsForMonth)
        {
            Random randomNum = new Random();
            empType = randomNum.Next(0, 2);
            switch (empType) 
            {
                case 0:
                    workHours = FULL_TIME_HOUR;
                    break;
                case 1:
                    workHours = PART_TIME_HOUR;
                    break;
                default:
                    break;
            }

            if ((MONTHLY_WORKING_HOURS - workinghrsForMonth) < FULL_TIME_HOUR)
            {
                workHours = PART_TIME_HOUR;
            }

            return workHours;
        }
        public int monthlyWage()
        {
            int employeeMonthlyWage = 0;
            int daysWorkedInMonth = 0;
            while (daysWorkedInMonth < MONTHLY_DAYS && workinghrsForMonth < MONTHLY_WORKING_HOURS && days <= 20)
            {
                //Employee Present or Absent
                isEmployeePresent = this.employeeAttendance();
                if (isEmployeePresent == true)
                {
                    Random Number = new Random();
                    empType = Number.Next(0, 2);
                    workHours = workingHoursForDay(workinghrsForMonth);
                    //dailyWage
                    wageForDay = this.dailyEmployeeWages(workHours, WAGE_PER_HOUR);
                    daysWorkedInMonth++;
                    workinghrsForMonth += workHours;
                }
                else
                {
                    wageForDay = NO_WAGE;
                }
                days++;
                // Caclulating monthly wage
                employeeMonthlyWage += wageForDay;
            }
            
        }
            return employeeMonthlyWage;
        
    }
}
