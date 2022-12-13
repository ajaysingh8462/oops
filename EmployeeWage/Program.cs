using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmployeeWage.EmpWage;

namespace EmployeeWage
{
    class program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject TATA = new EmpWageBuilderObject("TATA", 20, 20, 100);
            EmpWageBuilderObject INFOSYS = new EmpWageBuilderObject("INFOSYS", 30, 18, 90);

            TATA.CalculateSalery();
            Console.WriteLine(TATA.Result());
            INFOSYS.CalculateSalery();
            Console.WriteLine(INFOSYS.Result());
        }
    }

}