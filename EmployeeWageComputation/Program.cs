using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Program
    {
        // Main Method /Entry point
        static void Main(string[] args)
        {
            //printing message on console
            Console.WriteLine("Welcome To Employee Wage Computation Program \n");
            //Creating Object for each company and passing value to constructor.
            CalculateEmpWage company1 = new CalculateEmpWage("Dmart", 30, 120, 25);     
            CalculateEmpWage company2 = new CalculateEmpWage("Reliance", 25, 125, 24);
            CalculateEmpWage company3 = new CalculateEmpWage("Amazon", 40, 110, 22);
            company1.WageCompute();
            company2.WageCompute();
            company3.WageCompute();
            Console.ReadLine();
        }
    }
}
