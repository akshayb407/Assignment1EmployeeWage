using System;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isFullTime = 1;
            int isPartTime = 2;
            int perHrWage = 20;
            int empHrs = 0;            
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if(empCheck == isFullTime)
            {
                Console.WriteLine("Employee is Present isFullTime");
                empHrs = 8;
            }
            else if(empCheck == isPartTime)
            {
                Console.WriteLine("Employee is Present isPartTime");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * perHrWage;
            Console.WriteLine("Employee Wage =" +empWage);
        }

    }
}
