using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CalculateEmpWage
    {
        /* Uc - 8 Implementation
         * In this branch, Computing Wage For a Employee 
         * of multiple Companies.
         */
        //Constant Variables.
        const int FULL_TIME = 1;
        const int PART_TIME = 2;

        //static variable
        public static int emphrs;
                
        // method to perform Employee Wage Computation program using parameters.
        public static void WageCompute(string company,int wagePrHrs,int totalWorkHrs,int totalWorkDay)
        {
            //Local Variables
            int totalWage = 0;
            int totalEmpWrkHr = 0;
            int totalEmpwrkDay = 1;
            //Creating Object of Random Class
            Random randomNum = new Random();         
            //Checking condition.           
            while (totalEmpWrkHr <= totalWorkHrs && totalEmpwrkDay <= totalWorkDay )
            {            
                int empCheck = randomNum.Next(0, 3);     //generating random number from 0 to 2.
                GetEmpHrs(empCheck);                    //calling static method to get emp work hr.
                int empWage = emphrs * wagePrHrs;
                Console.WriteLine("Emp wage for day{0} is: {1}", totalEmpwrkDay, empWage);
                totalWage += empWage;
                totalEmpWrkHr = emphrs + totalEmpWrkHr;      //Computing Total Work Hrs of Employee Day wise.
                totalEmpwrkDay++;                           //incrementing Number of Day Worked.
            }
            Console.WriteLine("\nEmployee of company:{0} and Total wage is:{1} ",company,totalWage);
        }

        //Method to Get Employee work hours.
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
