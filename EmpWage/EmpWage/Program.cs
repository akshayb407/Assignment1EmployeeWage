using System;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isFullTime = 1;
            int perHrWage = 20;
            int empHrs = 8;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if(empCheck == isFullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * perHrWage;
            Console.WriteLine("Employee Wage =" +empWage);
        }

    }
}
