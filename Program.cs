using System;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeWages
{
    class Program
    {
        private static int FULL_TIME = 8;
        private static int PART_TIME = 4;
        private static int WAGE_PER_HOUR = 20;

        private static int employeeMonthlyWage;
        private static object dailyEmployeeWages;

        static void Main(string[] args)
        {
            ArrayList arryList1 = new ArrayList();
            arryList1.Add(dailyEmployeeWages);
            Console.WriteLine("Welcome to Employee Wages Computation");
            EmployeeWages emp = new EmployeeWages(FULL_TIME, PART_TIME, WAGE_PER_HOUR);
            employeeMonthlyWage = emp.monthlyWage();
            Console.WriteLine(employeeMonthlyWage);
        }
    }

}
