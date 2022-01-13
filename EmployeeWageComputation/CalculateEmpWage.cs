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
            /* Uc - 3 Implementation
             * In this branch we are adding FullTime and PartTime Employee.
             * Computing Wage For FullTime and PartTime Employee.
             */
            //Instance Variables.
            int fullTime = 1;
            int partTime = 2;
            int empWageHrs = 0;
            int empWagePrHrs = 20;
            Random random = new Random();           //Creating Object of Random Class
            int empAttendence = random.Next(0, 3); //Generating random number between 0 and 3.
            
            //Checking condition using if else statement.
            if (empAttendence == fullTime)
            {
                Console.WriteLine("Employee is Present");
                empWageHrs = 8;
            }
            else if (empAttendence == partTime)
            {
                Console.WriteLine("Employee is Present");
                empWageHrs = 4;
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
