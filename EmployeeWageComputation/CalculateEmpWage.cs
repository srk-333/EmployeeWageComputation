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
            /* Uc - 1 Implementation
             * In this branch we are checking Employee is present or not using Random class Object.
             */
            int present = 1;
            Random random = new Random();           //Creating Object of Random Class
            int empAttendence = random.Next(0, 2); //Generating random number between 0 and 1.
            
            //Checking condition using if else statement.
            if (empAttendence == present)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is not Present");
            }
        }
    }
}
