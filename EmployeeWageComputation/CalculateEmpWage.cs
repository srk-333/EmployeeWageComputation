using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CalculateEmpWage
    {
        /* Uc - 12 Implementation
         * In this branch, Computing total Wage of a Company 
         * by using List And Dicitionary.
         */
        //Constant Variables.
        const int FULL_TIME = 1;
        const int PART_TIME = 2;

        //static variable
        public static int emphrs;
       
        //Use of List and Dictionary 
        public IList<EmpWage> CompanyEmpWge = new List<EmpWage>();
        public IDictionary<string,EmpWage> employees = new Dictionary<string,EmpWage>();
       
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
            EmpWage empWage = new EmpWage(company, wagePrHrs, totalWorkHrs, totalWorkDay);
            CompanyEmpWge.Add(empWage);       // Adding data in list
            employees.Add(company,empWage);  // Adding data in Dictionary as key value Pair
 
        }
        /// <summary>
        /// Gets the wage for each key
        /// </summary>
        public void GetWage()
        {
            //looping to get and set total wage for each List index
            foreach (EmpWage empWage in this.CompanyEmpWge)
            {
                empWage.SetTotalWage(WageCompute(empWage));
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
