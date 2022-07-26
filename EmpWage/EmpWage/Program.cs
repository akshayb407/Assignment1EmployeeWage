using System;

namespace EmpWage
{
    internal class Program
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int perHrWage = 20;
        public const int numOfWorkingDays = 20;
        public const int maxHrsInMonth = 100;
        static void Main(string[] args)
        {
          
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHrsInMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case isPartTime:
                        empHrs = 4;
                      break;

                    case isFullTime:
                        empHrs = 8;
                       break;

                    default:
                        empHrs = 0;               
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays +"Emp Hrs : "  + empHrs);
            }
            int totalEmpWage = totalEmpHrs * perHrWage;
            Console.WriteLine("Total Employee Wage in Month =" + totalEmpWage);
        }

    }
}
