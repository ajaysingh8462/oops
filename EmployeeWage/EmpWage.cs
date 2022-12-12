using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpWage
    {
       
        public void  CalculateSalery(string companyName, int perHour, int maxDaysInMonth, int maxWorkinHour)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.ForegroundColor = ConsoleColor.Gray;
            int empPresent = 1;
            int empPartTime = 2;
           
                int empHrs =0, totalWorkingDays = 0 , totalEmphr=0;
            while (totalEmphr <= maxWorkinHour && totalWorkingDays < maxDaysInMonth)
            {
                totalWorkingDays++;
                Random random = new Random();
                int check = random.Next(0, 3);

                switch (check)
                {
                    case 1:
                        empHrs = 8;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("EMPLOYEE IS PRESENT");

                        break;
                    case 2:
                        empHrs = 4;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("EMPLOYEE IS PART TIME");

                        break;
                    default:
                        empHrs = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("EMPLOYEE IS ABSENT");
                        break;
                }

                totalEmphr = totalEmphr + empHrs;
               
            }
            int totalEmpWge = totalEmphr * perHour;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("total employee wage : " + totalEmpWge);
            Console.WriteLine("total employee wage : " + companyName+ " " +  totalEmpWge);


        }
    }
}
