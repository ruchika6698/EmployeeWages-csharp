using System;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeWages
{
    class Program
    {
        /// <summary>
        /// constants specific to any full time hours, part time hours and wage per hour Employees
        /// </summary>
        private const int FULL_TIME = 8;
        private const int PART_TIME = 4;
        private const int WAGE_PER_HOUR = 20;

        private static int employeeMonthlyWage;
        public static int WAGES_PER_HOUR { get; private set; }

        /// <summary>
        /// main method, program execution 
        /// </summary>
        static void Main(string[] args)
        {
            Dictionary<string, int> dailyWage = new Dictionary<string, int>();

            Console.WriteLine("Welcome to Employee Wages Computation");
            EmployeeWages emp = new EmployeeWages(FULL_TIME, PART_TIME,WAGES_PER_HOUR);
            employeeMonthlyWage = emp.monthlyWage();

            foreach (var a in dailyWage)     // printing the daily wage
            {
                Console.WriteLine($"{a.Key} : {a.Value}");
            }

            Console.WriteLine($"Total Monthly Wage : {employeeMonthlyWage}");
        }
    }

}
