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
            /* Uc - 2 Implementation
             * In this branch we are calculating Employee Wage.
             */
            //Instance Variables.
            int present = 1;
            int empWageHrs = 0;
            int empWagePrHrs = 20;
            Random random = new Random();           //Creating Object of Random Class
            int empAttendence = random.Next(0, 2); //Generating random number between 0 and 1.
            
            //Checking condition using if else statement.
            if (empAttendence == present)
            {
                Console.WriteLine("Employee is Present");
                empWageHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is not Present");
            }
            int totalWage = empWagePrHrs * empWageHrs;
            Console.WriteLine("Employee total Wage: "+totalWage);
        }
    }
}
