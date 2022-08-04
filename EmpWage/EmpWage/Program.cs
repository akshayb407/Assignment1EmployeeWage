using System;

namespace EmpWage
{
    internal class Program
    {

        static void Main(string[] args)
        {


            EmployeeWages reliance = new EmployeeWages("Reliance", 20, 20, 100);
            reliance.computeEmpWage();

            EmployeeWages Dmart = new EmployeeWages("Dmart", 20, 20, 100);
            Dmart.computeEmpWage();


        }
    }
}
