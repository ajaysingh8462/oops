using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpWage
    {
        public class EmpWageBuilderObject
        {
            //properties 
            private string company;
            private int perHour;
            private int maxDaysInMonth;
            private int maxWorkinHour;
            private int totalEmpWge;
            public EmpWageBuilderObject(string company, int perHour, int maxDaysInMonth, int maxWorkinHour)
            {

                this.company = company;
                this.perHour = perHour;
                this.maxDaysInMonth = maxDaysInMonth;
                this.maxWorkinHour = maxWorkinHour;
            }

            public void CalculateSalery()
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Welcome to Employee Wage Computation Program");
                Console.ForegroundColor = ConsoleColor.Gray;
                int empPresent = 1;
                int empPartTime = 2;

                int empHrs = 0, totalWorkingDays = 0, totalEmphr = 0;
                while (totalEmphr <= this.maxWorkinHour && totalWorkingDays < this.maxDaysInMonth)
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

                    totalEmphr += empHrs;
                    Console.WriteLine("Days :" + totalWorkingDays + "Emp Hrs :" +empHrs);

                }
                int totalEmpWge = totalEmphr * this.perHour;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("total employee wage : " + company + " " + totalEmpWge);

            }

            public string Result()
            {
                return "Total Employee wage for Comapny : " + this.company + " is " + totalEmpWge;
            }
        }
    }
}
