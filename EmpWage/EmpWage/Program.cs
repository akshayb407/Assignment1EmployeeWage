using System;

namespace EmpWage
{
    internal class Program
    {

        static void Main(string[] args)
        {


            EmployeeWages  class1 = new EmployeeWages();
            class1.addCompanyEmpWage("DMart", 20, 20, 100);
            class1.addCompanyEmpWage("reliance", 20, 20, 100);

            class1.ToString();
        }
    }
}
