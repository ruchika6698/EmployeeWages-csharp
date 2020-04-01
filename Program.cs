using System;

namespace EmployeeWages
{
    class Program
    {
        public static int WAGE_PER_HOUR = 20;
        public static int FULL_TIME_HOUR = 8;
        public static int PART_TIME_HOUR = 4;
        public static int NO_WAGE = 0;

        private static bool isEmployeePresent;
        private static int wageForDay;
        private static int workHours;
        private static int empType;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation");
            bool isEmployeePresent;
            Employee emp = new Employee();
            isEmployeePresent = emp.employeeAttendance();
            if( isEmployeePresent == true )
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
                wageForDay = emp.dailyEmployeeWages(workHours, WAGE_PER_HOUR);
            }
            else
            {
                wageForDay = NO_WAGE;
            }

            Console.WriteLine($"{isEmployeePresent}, {wageForDay}");
        }
    }

}
