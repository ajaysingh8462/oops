using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    
        class CompanyEmpWage
    {
            //properties 
            public string company;
            public int perHour;
            public int maxDaysInMonth;
            public int maxWorkinHour;
            public int totalEmpWge;
            public CompanyEmpWage(string company, int perHour, int maxDaysInMonth, int maxWorkinHour)
            {

                this.company = company;
                this.perHour = perHour;
                this.maxDaysInMonth = maxDaysInMonth;
                this.maxWorkinHour = maxWorkinHour;
            }
            public void SetTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWge = totalEmpWage;
            }

            public string Result()
            {
                return "Total Employee wage for Comapny : " + this.company + " is " + this.totalEmpWge;
            }
        }
    
}
