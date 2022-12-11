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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.ForegroundColor = ConsoleColor.Gray;
            int empPresent = 1;
            int empPartTime = 2;
            int perHour = 20;
            int fullTime = 8;
            int harfTime = 4;
            Random random = new Random();
            int check = random.Next(0, 3);
            
            switch(check)
            {
                case 1:

                Console.WriteLine("EMPLOYEE IS PRESENT");
                int PerDay = perHour * fullTime;
                Console.WriteLine("Daily wadge : " + PerDay);
                    break;
                case 2:
                Console.WriteLine("EMPLOYEE IS PART TIME");
                int HalfDay = perHour * harfTime;
                Console.WriteLine("Daily wadge : " + HalfDay);
                    break;
                default:
                Console.WriteLine("EMPLOYEE IS ABSENT");
                    break;
            }


        }
    }
}
