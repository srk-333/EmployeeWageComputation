using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CalculateEmpWage
    {
        //Instance Variables.
        const int FULL_TIME = 1;
        const int PART_TIME =2;        
        int emphrs;
        int wagePrHrs = 20;      
        int totalWage;      
        // method to perform Employee Wage Computation program
        public void WageCompute()
        {
            /* Uc - 6 Implementation
             * In this branch, Computing Wage For a Employee for a given condition
             * condition is employee total work hrs becomes 100 or 20 days for a Month 
             */
            //Local Variables.
            int totalWorkHrs = 100;
            int totalWorkDay = 20;
            int totalEmpWrkhr = 0;
            int totalEmpwrkDay = 1;
            Random randomNum = new Random();          //Creating Object of Random Class
            //Checking condition.           
            while (totalEmpWrkhr <= totalWorkHrs && totalEmpwrkDay <= totalWorkDay )
            {            
                int empCheck = randomNum.Next(0, 3);     //generating random number from 0 to 2.
                switch (empCheck)                    //passing random number into switch to get employee work hours.
                { 
                    case FULL_TIME:                      
                        emphrs = 8;
                        break;
                    case PART_TIME:                       
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                int empWage = emphrs * wagePrHrs;
                Console.WriteLine("Emp wage for day{0} is: {1}", totalEmpwrkDay, empWage);
                totalWage += empWage;
                totalEmpWrkhr = emphrs + totalEmpWrkhr;      //Computing Total Work Hrs of Employee Day wise.
                totalEmpwrkDay++;                           //incrementing Number of Day Worked.
            }
            Console.WriteLine("\nEmployee total Wage: "+totalWage);
        }
    }
}
