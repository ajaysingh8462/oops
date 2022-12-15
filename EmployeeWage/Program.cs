using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static EmployeeWage.EmpWage;

namespace EmployeeWage
{
    class program
    {
        static void Main(string[] args)
        {

            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.AddCompanyEmpWage("TATA", 20, 20, 100);
            empWageBuilder.AddCompanyEmpWage("INFOSYS", 30, 18, 90);
            empWageBuilder.ComputeEmpWage();
            Console.WriteLine($"Total wage for TATA Company : {empWageBuilder.getTotalWage("TATA")}");
        }
    }
}

              