using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CalculateEmpWage
    {
        // static method to perform Employee Wage Computation program
        public static void WageCompute()
        {
            /* Uc - 6 Implementation
             * In this branch, Computing Wage For a Employee for a given condition
             * condition is employee total work hrs becomes 100 or 20 days for a Month 
             */
            //Instance Variables.
            int emphrs;
            int wagePrHrs = 20;           
            int totalWorkHrs= 100 ;
            int totalWorkDay= 20;
            int totalEmpWrkhr = 0;
            int totalEmpwrkDay = 0;
            Random random = new Random();    //Creating Object of Random Class

            //Checking condition.           
            int i = 0;
            while (totalEmpWrkhr <= totalWorkHrs && totalEmpwrkDay <= totalWorkDay )
            {
                totalEmpwrkDay++;                       //incrementing Number of Day Worked.
                int randomNum = random.Next(0, 3);     //generating random number from 0 to 2.
                switch (randomNum)                    //passing random number into switch to get employee work hours.
                { 
                    case 0:                      
                        emphrs = 8;
                        break;
                    case 1:                       
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                totalEmpWrkhr = emphrs + totalEmpWrkhr;     //Computing Total Work Hrs of Employee Day wise.
                i++;                                       // incrementing i value to iteretate loop.
            }
            int totalWage = totalEmpWrkhr * totalWorkDay * wagePrHrs;    //Total Wage for a Month
            Console.WriteLine("Employee total Wage: " + totalWage);
        }
    }
}
