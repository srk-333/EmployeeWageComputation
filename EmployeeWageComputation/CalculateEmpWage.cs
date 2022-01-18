using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CalculateEmpWage
    {
        /* Uc - 9 Implementation
         * In this branch, Computing Wage For a Employee 
         * of multiple Companies using constructor
         * so,that each company will have own object.
         */
        //Constant Variables.
        const int FULL_TIME = 1;
        const int PART_TIME = 2;

        //static variable
        public static int emphrs;
       
        //fixed size Array
        EmpWage[] CompanyRecord  = new EmpWage[5];
        public int numOfCompany = 0;    //array index position
        /// <summary>
        /// Adds the company details in a array..
        /// </summary>
        /// <param name="company">The company.</param>
        /// <param name="wagePrHrs">The wage pr HRS.</param>
        /// <param name="totalWorkHrs">The total work HRS.</param>
        /// <param name="totalWorkDay">The total work day.</param>
        public void AddCompany(string company, int wagePrHrs, int totalWorkHrs, int totalWorkDay)
        {
            //creating obj of EmpWage and passing constructor values
            EmpWage emp = new EmpWage(company,wagePrHrs,totalWorkHrs,totalWorkDay);
            this.CompanyRecord[this.numOfCompany] = emp;       //storing details in array with respecting index.
            numOfCompany++;   //incrementing index value.
        }
        /// <summary>
        /// Gets the wage for each Index.
        /// </summary>
        public void GetWage()
        {
            //looping to get and set total wage for each index value.
            for (int i = 0; i < numOfCompany; i++)
            {
                int result = WageCompute(this.CompanyRecord[i]);  //calling method with index values and storing returning value in variable. 
                this.CompanyRecord[i].SetTotalWage(result);      //Updating Total wage for every index value in array.
            }
        }
                
        // method to perform Employee Wage Computation program using parameters.
        public int WageCompute( EmpWage emp )
        {
            //Local Variables
            int totalWage = 0;
            int totalEmpWrkHr = 0;
            int totalEmpwrkDay = 1;
            //Creating Object of Random Class
            Random randomNum = new Random();         
            //Checking condition.           
            while (totalEmpWrkHr <= emp.totalWorkHrs && totalEmpwrkDay <= emp.totalWorkDay )
            {            
                int empCheck = randomNum.Next(0, 3);     //generating random number from 0 to 2.
                GetEmpHrs(empCheck);                    //calling static method to get Emp hrs.
                int empWage = emphrs *emp.wagePrHrs;
                totalWage += empWage;
                totalEmpWrkHr = emphrs + totalEmpWrkHr;      //Computing Total Work Hrs of Employee Day wise.
                totalEmpwrkDay++;                           //incrementing Number of Day Worked.
            }
            Console.WriteLine("\nEmployee of company : {0} , Total wage is : {1} ",emp.company,totalWage);
            return totalWage;
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
