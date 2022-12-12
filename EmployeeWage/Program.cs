using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class program
    {
        static void Main(string[] args)
        {
            EmpWage salery = new EmpWage();

            salery.CalculateSalery("TATA", 20, 20, 100);
            salery.CalculateSalery("INFOSYS", 30, 18, 90);
        }
    }

}