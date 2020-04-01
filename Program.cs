using System;

namespace EmployeeWages
{
    class Program
    {
        public static object EmployeePresent { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation");
            bool isEmployeePresent;
            Employee emp = new Employee();
            isEmployeePresent = emp.employeeAttendance();
        }
    }

}
