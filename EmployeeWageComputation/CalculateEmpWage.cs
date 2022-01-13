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
            /* Uc - 5 Implementation
             * In this branch .
             * Computing Wage For a Month of Employee.
             */
            //Instance Variables.
            int empWageHrs = 0;
            int empWagePrHrs = 20;
            int empWorkPrMonth = 20;
            Random random = new Random();           //Creating Object of Random Class
            int empAttendence = random.Next(0, 3); //Generating random number between 0 and 3.

            //Checking employee Attendence using Switch Case statement.
            switch (empAttendence)
            {
                case 0:
                    Console.WriteLine("Employee is not Present");
                    break;
                case 1:
                    Console.WriteLine("Employee is FullTime");
                    empWageHrs = 8;
                    break;
                case 2:
                    Console.WriteLine("Employee is PartTime");
                    empWageHrs = 4;
                    break;
            }
            int totalWage = empWorkPrMonth * empWagePrHrs * empWageHrs;
            Console.WriteLine("Employee total Wage for Month: "+totalWage);
        }
    }
}
