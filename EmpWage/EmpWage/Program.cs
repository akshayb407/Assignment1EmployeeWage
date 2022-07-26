using System;

namespace EmpWage
{
    internal class Program
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int perHrWage = 20;
        static void Main(string[] args)
        {
          
            int empHrs = 0;            
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case isPartTime:
                     empHrs = 4;
                    Console.WriteLine("Employee is Present isPartTime");
                break;
                case isFullTime:
                     empHrs = 8;
                    Console.WriteLine("Employee is Present isFullTime");
                break;

                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is Absent");
                break;


            }
            empWage = empHrs * perHrWage;
            Console.WriteLine("Employee Wage =" +empWage);
        }

    }
}
