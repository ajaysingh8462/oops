using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpWage
    {
        public void Emp()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            int empPresent = 1;
            int empPartTime = 2;
            int perHour = 20;
            int fullTime = 8;
            int harfTime = 4;
            Random random = new Random();
            int check = random.Next(0, 3);
            if (check == empPresent)
            {
                Console.WriteLine("EMPLOYEE IS PRESENT");
                int PerDay = perHour * fullTime;
                Console.WriteLine("Daily wadge : " + PerDay);
            }
            else if (check == empPartTime)
            {
                Console.WriteLine("EMPLOYEE IS PART TIME");
                int HalfDay = perHour * harfTime;
                Console.WriteLine("Daily wadge : " + HalfDay);
            }
            else
            {
                Console.WriteLine("EMPLOYEE IS ABSENT");
            }
        }
    }
}
