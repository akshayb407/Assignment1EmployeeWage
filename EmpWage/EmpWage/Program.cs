using System;

namespace EmpWage
{
    internal class Program
    {

        static void Main(string[] args)
        {
            EmployeeWages employeeWage = new EmployeeWages();

            employeeWage.GetEmployeeWage("reliance", 20, 100, 20);
            employeeWage.GetEmployeeWage("Tata", 40, 150, 40);
        }


    }
}
