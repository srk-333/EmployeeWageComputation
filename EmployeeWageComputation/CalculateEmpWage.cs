using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CalculateEmpWage
    {
        /* Uc - 7 Implementation
         * In this branch, Computing Wage For a Employee 
         * using class variables and methods.
         */
        //Constant Variables.
        const int FULL_TIME = 1;
        const int PART_TIME =2;
        const int WAGE_PR_HRS = 20;
        const int TOTAL_WORK_HRS = 100;
        const int TOTAL_WORK_DAY = 20;

        //Instanse variable
        int totalEmpWrkHr = 0;
        int totalEmpwrkDay = 1;
        public static int emphrs;            
        int totalWage;   
        
        // method to perform Employee Wage Computation program
        public void WageCompute()
        {
            Random randomNum = new Random();          //Creating Object of Random Class
            //Checking condition.           
            while (totalEmpWrkHr <= TOTAL_WORK_HRS && totalEmpwrkDay <= TOTAL_WORK_DAY )
            {            
                int empCheck = randomNum.Next(0, 3);     //generating random number from 0 to 2.
                GetEmpHrs(empCheck);                    //calling static method to get emp work hr.
                int empWage = emphrs * WAGE_PR_HRS;
                Console.WriteLine("Emp wage for day{0} is: {1}", totalEmpwrkDay, empWage);
                totalWage += empWage;
                totalEmpWrkHr = emphrs + totalEmpWrkHr;      //Computing Total Work Hrs of Employee Day wise.
                totalEmpwrkDay++;                           //incrementing Number of Day Worked.
            }
            Console.WriteLine("\nEmployee total Wage: "+totalWage);
        }

        //Static Method to Get Employee work hours.
        public static void GetEmpHrs(int empCheck)
        {
            switch (empCheck)       //passing random number into switch to get employee work hours.
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

        }
    }
}
