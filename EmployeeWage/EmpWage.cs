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
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void AddCompanyEmpWage(string company, int perHour, int maxDaysInMonth, int maxWorkinHour)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, perHour, maxDaysInMonth, maxWorkinHour);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }

        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.SetTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.Result());
            }
        }
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWge;
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
  

