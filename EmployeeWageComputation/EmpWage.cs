using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWage
    {
        //Instance variables.
        public string company;
        public int wagePrHrs, totalWorkHrs, totalWorkDay,totalWage;
        //Constructor to set value for each object.
        public EmpWage(string company, int wagePrHrs, int totalWorkHrs, int totalWorkDay)
        {
            this.company = company;
            this.wagePrHrs = wagePrHrs;
            this.totalWorkHrs = totalWorkHrs;
            this.totalWorkDay = totalWorkDay;
        }
        public void SetTotalWage(int totalWage)
        {
            this.totalWage = totalWage;
        }
    }
}