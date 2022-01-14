using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class SwitchCase
    {
        /* Here we are implementing Switch Case statement
         * Using  Constant Variables.
         * In case value we cann't pass instance/local or static variables.
         * so using Constant variables
         * Constant variable name will always be in capital Letter.
         * if we have 2 word then use underscore sign. 
         */
        public static void PerformSwitchUse()
        {
            int emphrs;
            int empWagePrHrs = 20;
            const int FULL_TIME = 1;           //Constant variables.
            const int PART_TIME = 2;          
            Random random = new Random();
            int randomNum = random.Next(0, 3);     //generating random number from 0 to 2.
            switch (randomNum)                    //passing random number into switch to get employee work hours.
            {
                case FULL_TIME:              //passing constant variable in case value.
                    emphrs = 8;
                    break;
                case PART_TIME:
                    emphrs = 4;
                    break;
                default:
                    emphrs = 0;
                    break;
            }
            int totalWage = emphrs * empWagePrHrs;                //Total Wage Computing
            Console.WriteLine("Employee total Wage: " + totalWage);
        }
}
}
