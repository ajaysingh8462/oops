using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{


    interface IEmployeeWage
    {
        void ComputeEmpWage();
        void AddCompanyEmpWage(string company, int perHour, int maxDaysInMonth, int maxWorkinHour);
    }

    public class EmpWageBuilderArray : IEmployeeWage
    {
        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void AddCompanyEmpWage(string company, int perHour, int maxDaysInMonth, int maxWorkinHour)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, perHour, maxDaysInMonth, maxWorkinHour);
            numOfCompany++;
        }

        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].Result());
            }
        }


        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.ForegroundColor = ConsoleColor.Gray;
            
            int days;
            int dailyWage = 0;

            int empHrs = 0, totalWorkingDays = 0, totalEmphr = 0;
            for (days = 1; days <= companyEmpWage.maxDaysInMonth; days++)
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
                        dailyWage = companyEmpWage.perHour *empHrs;

                        break;
                    case 2:
                        
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("EMPLOYEE IS PART TIME");
                        dailyWage = companyEmpWage.perHour*empHrs;

                        break;
                    default:
                        
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("EMPLOYEE IS ABSENT");
                        break;
                }

                totalEmphr += dailyWage / 20;
                companyEmpWage.totalEmpWge += dailyWage;
                if (totalEmphr >= companyEmpWage.maxWorkinHour) 
                    break;
                Console.WriteLine(" Day#: " + days + " Emp Hrs : " + totalEmphr);

            }
            return totalEmphr * companyEmpWage.perHour;

        }

       
    }
}
  

