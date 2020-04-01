using System;

namespace EmployeeWages
{
    class Program
    {
        public static int WAGE_PER_HOUR = 20;
        public static int FULL_DAY_HOUR = 8;
        public static int NO_WAGE = 0;

        private static bool isEmployeePresent;
        private static int wageForDay;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation");
            bool isEmployeePresent;
            Employee emp = new Employee();
            isEmployeePresent = emp.employeeAttendance();
            if( isEmployeePresent == true )
            {
                wageForDay = emp.ailyEmployeeWages(FULL_DAY_HOUR, WAGE_PER_HOUR);
            }
            else
            {
                wageForDay = NO_WAGE;
            }

            Console.WriteLine($"{isEmployeePresent}, {wageForDay}");
        }
    }

}
