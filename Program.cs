﻿using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation");
            Employee emp = new Employee();
            employeeMonthlyWage = emp.monthlyWage();
            Console.WriteLine(employeeMonthlyWage);
        }
    }

}
