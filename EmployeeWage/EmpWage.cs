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
            int maxDaysInMonth = 20;
            int maxWoorkinHour= 100;
            int empHrs = 0, empwage = 0, totalErning = 0, totalWorkingDays=0 , totalEmphr=0; 
            while (totalEmphr<=maxWoorkinHour&&totalWorkingDays < maxDaysInMonth)
            {
                totalWorkingDays++;
                Random random = new Random();
                int check = random.Next(0, 3);
                      
                switch (check)
                {
                    case 1:
                        empHrs = 8;

                        Console.WriteLine("EMPLOYEE IS PRESENT");
  
                        break;
                    case 2:
                        empHrs = 4;
                        Console.WriteLine("EMPLOYEE IS PART TIME");
                         
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("EMPLOYEE IS ABSENT");
                        break;
                }
                empwage = empHrs * perHour;
                maxWoorkinHour += totalEmphr;
                totalErning += empwage;
                Console.WriteLine("employee wage:" + empwage);
            }
            Console.WriteLine("total working hour:" + maxWoorkinHour);
            Console.WriteLine("total employee wage:" + totalErning);


        }
    }
}
