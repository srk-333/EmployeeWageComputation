using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CalculateEmpWage : IEmpWageCompute
    {
        /* Uc - 14 Implementation
         * In this branch implemented, 
         * Get Total Wage when Queried by a company name.
         */
        //Constant Variables.
        const int FULL_TIME = 1;
        const int PART_TIME = 2;
        public int dailyWage = 0;
        //static variable
        public static int empHrs;
       
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
                Console.WriteLine(empWage.toString());    
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
                dailyWage = empHrs *emp.wagePrHrs;
                totalWage = totalEmpWrkHr * emp.wagePrHrs;
                totalEmpWrkHr = empHrs + totalEmpWrkHr;      //Computing Total Work Hrs of Employee Day wise.
                totalEmpwrkDay++;                           //incrementing Number of Day Worked.
            }
            return totalWage;
        }

        //Method to Get Employee work hours.
        public static void GetEmpHrs(int empCheck)
        {
            switch (empCheck)       //passing random number into switch to get employee work hours.
            {
                case FULL_TIME:
                    empHrs = 8;
                    break;
                case PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
        }

        //Method to get Total Wage as per company.
        public int GetTotalWage(string company)
        {
            return this.employees[company].totalWage;
        }
    }
}
